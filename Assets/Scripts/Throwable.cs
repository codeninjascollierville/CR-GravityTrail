using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Throwable : MonoBehaviour
{
    public GameObject shuriken;
    public Vector3 offset;
    public int throwableCounter;
    public Text CollectableText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && throwableCounter >= 1)
        {
            Vector3 throwablePosition = transform.position + offset;
            Instantiate(shuriken, throwablePosition, transform.rotation);
            throwableCounter--;
            CollectableText.text = throwableCounter.ToString();
        }
        offset = transform.localScale.x * new Vector3(1, 0, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collectable")
        {
            throwableCounter++;
            Destroy(collision.gameObject);
            CollectableText.text = throwableCounter.ToString();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birb : MonoBehaviour
{
    public Rigidbody2D enemyRigidBody;
    public float xForce = 140;
    public float yForce = 500;
    public float xDirection;
    public float minX;
    public float maxX;
      // Start is called before the first frame update
    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
      if (collision.gameObject.tag == "Ground")
      {
        Vector2 jumpForce = new Vector2(xForce * xDirection, 0);
        enemyRigidBody.AddForce(jumpForce);
      }
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
      if(transform.position.x <= minX)
      {
        xDirection = 1;
        enemyRigidBody.AddForce(Vector2.right * xForce);
      }
      if(transform.position.x >= maxX)
      {
        xDirection = -1;
        enemyRigidBody.AddForce(Vector2.left * xForce);
      }
    }
}

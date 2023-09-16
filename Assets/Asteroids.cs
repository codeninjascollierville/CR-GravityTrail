using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public Rigidbody2D RigidBody;
    public float xDirection;
    public float yDirection;
    // Start is called before the first frame update
    void Awake()
    {
        Vector3 movement = new Vector3(Random.Range(1,10) * xDirection, Random.Range(1,10) * yDirection);
        RigidBody.AddForce(movement);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        
        Vector3 movement = new Vector3(1 * xDirection / 10, 1 * yDirection / 10);
        transform.position = transform.position + movement;
        if(transform.position.x >= maxX)
        {
            xDirection = -1;
        }
        if(transform.position.y >= maxY)
        {
            yDirection = -1;
        }
        if(transform.position.y <= minY)
        {
            yDirection = 1;
        }
        if(transform.position.x <= minX)
        {
            xDirection = 1;
        }
    }
}

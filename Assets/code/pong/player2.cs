using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class player2 : MonoBehaviour

{
    public Rigidbody bal;
    public float speed = 15f;
    public Vector3 startPosition;
    public Rigidbody rb;


    void Start()
    {
        startPosition = transform.position;
    }

    private void FixedUpdate()
    {
        if(this.bal.velocity.x > 0.0f)
        {
            if(this.bal.position.y > this.transform.position.y)
            {
                GetComponent<Rigidbody>().AddForce(Vector3.up * this.speed);
            }
            else if (this.bal.position.y < this.transform.position.y)
            {
                GetComponent<Rigidbody>().AddForce(Vector3.down * this.speed);
            }

        }
        else
        {
            if(this.transform.position.y > 0.0f)
            {
                GetComponent<Rigidbody>().AddForce(Vector3.down * this.speed);
            }
            else if (this.transform.position.y < 0.0f)
            {
                GetComponent<Rigidbody>().AddForce(Vector3.up * this.speed);
            }
            
        }
        
    }
    public void Reset()
    {
        rb.velocity = Vector3.zero;
        transform.position = startPosition;
    }
}

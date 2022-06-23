using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class paddle : MonoBehaviour

{
    public bool isplayer1;
    public float speed;
    public Rigidbody rb;
    private float movement;
    public Vector3 startPosition;


    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isplayer1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }

        rb.velocity = new Vector3(rb.velocity.x, movement * speed);

    }

    public void Reset()
    {
        rb.velocity = Vector3.zero;
        transform.position = startPosition;
    }
}

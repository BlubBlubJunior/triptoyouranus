using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipmovement : MonoBehaviour
{
    private Rigidbody2D rb;

    public float maxVelocity = 3;

    public float rotationspeed = 3;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float yAxis = Input.GetAxis("Vertical");
        float xAxis = Input.GetAxis("Horizontal");

        thrustforward(yAxis);
        rotate(transform, xAxis * rotationspeed);
    }
    private void clampVelocity()
    {
        float x = Mathf.Clamp(rb.velocity.x, -maxVelocity, maxVelocity);
        float y = Mathf.Clamp(rb.velocity.y, -maxVelocity, maxVelocity);

        rb.velocity = new Vector2(x, y);
        
    }
    private void thrustforward(float amount)
    {
        Vector2 force = transform.up * amount;

        rb.AddForce(force);
    }
    private void rotate(Transform t, float amount)
    {
        t.Rotate(0, 0, amount);
    }
}

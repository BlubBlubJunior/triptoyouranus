using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

    public float speed;
    public float speedup;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
        Launch();
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
        
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
        
    }
    private void FixedUpdate()
    {
        speed += speedup;
    }
}

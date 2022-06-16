using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        enemy Enemy = collision.GetComponent<enemy>();
        if(Enemy != null)
        {
            Enemy.takedamage(20);
        }
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball2D : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
   


    // Start is called before the first frame update
    void Start()
    {
        
        Launch();
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        
        Launch();
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);


    }
}

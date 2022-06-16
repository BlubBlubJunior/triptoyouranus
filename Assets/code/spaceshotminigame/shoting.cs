using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoting : MonoBehaviour
{
    public Transform shootingpoint;
    public GameObject bulletprefab;

   
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(bulletprefab, shootingpoint.position, transform.rotation);
        }
    }
}

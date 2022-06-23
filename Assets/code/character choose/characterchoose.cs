using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterchoose : MonoBehaviour
{
    public GameObject left;
    public GameObject right;
    public GameObject main;
    public GameObject wayright;
    public GameObject wayleft;
    public GameObject leftenable;
    public GameObject rightenable;
    
    public void nextleft()
    {
        left.SetActive(true);
        main.SetActive(false);
        gameObject.SetActive(false);
        wayleft.SetActive(true);
        
    }
    public void nextright()
    {
        right.SetActive(true);
        main.SetActive(false);
        gameObject.SetActive(false);
        wayright.SetActive(true);
        wayleft.SetActive(false);
        leftenable.SetActive(true);
    }
    public void backmain()
    {
        right.SetActive(true);
        left.SetActive(false);
        gameObject.SetActive(false);
        

    }

}

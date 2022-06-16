using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class vraagbutton : MonoBehaviour
{
    public GameObject good;
    public GameObject enable;


    public void playgame()
    {
        good.SetActive(false);
        enable.SetActive(true);
    }
    
}

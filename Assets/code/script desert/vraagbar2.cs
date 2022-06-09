using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class vraagbar2 : MonoBehaviour
{
    public GameObject fout;
    public GameObject enable;
    public void playgame()
    {
        
        enable.SetActive(true);
        fout.SetActive(false);
        
    }
  
}

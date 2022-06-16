using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class esc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("esc");
        }
    }
}

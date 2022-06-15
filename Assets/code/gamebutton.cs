using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamebutton : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void games()
    {
        SceneManager.LoadScene("mario");
    }
}

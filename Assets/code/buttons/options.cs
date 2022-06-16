using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class options : MonoBehaviour
{

    public void playgame1()
    {
        SceneManager.LoadScene("options");
    }
    public void back1()
    {
        SceneManager.LoadScene("main manu");

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kamer3button : MonoBehaviour
{
    public void playgame3()
    {
        SceneManager.LoadScene("kamer3");
    }
    public void back3()
    {
        SceneManager.LoadScene("lobby");

    }
}


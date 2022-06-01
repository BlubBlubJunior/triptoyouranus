using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_back : MonoBehaviour
{
    public void playgame1()
    {
        SceneManager.LoadScene("kamer1");
    }
    public void back1()
    {
        SceneManager.LoadScene("lobby");

    }
}

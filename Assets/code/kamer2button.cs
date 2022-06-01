using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kamer2button : MonoBehaviour
{
    public void playgame2()
    {
        SceneManager.LoadScene("kamer2");
    }
    public void back2()
    {
        SceneManager.LoadScene("lobby");

    }
}

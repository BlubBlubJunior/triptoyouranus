using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamebutton : MonoBehaviour
{
    public GameObject pannel;
    private void Start()
    {
        pannel.SetActive(false);
    }
    public void games()
    {
        pannel.SetActive(true);
    }
    public void merorie()
    {
        SceneManager.LoadScene("pong");

    }
}

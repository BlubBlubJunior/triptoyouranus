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
    public void pong()
    {
        SceneManager.LoadScene("pong");

    }
    public void mario()
    {
        SceneManager.LoadScene("mario");

    }
    public void spacerock()
    {
        SceneManager.LoadScene("spacerockgame");

    }
}

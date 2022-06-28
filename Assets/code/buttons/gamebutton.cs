using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamebutton : MonoBehaviour
{
    public GameObject pannel;
    public GameObject chetley;
    public GameObject text2;
    public GameObject game;
    public GameObject rockofpong;
    private void Start()
    {
        
    }
    public void games()
    {
        pannel.SetActive(true);
        
    }
    public void pong()
    {
        SceneManager.LoadScene("pong menu");

    }
    public void text()
    {
        text2.SetActive(true);
        chetley.SetActive(false);
        game.SetActive(false);

    }
    public void spacerock()
    {
        SceneManager.LoadScene("spacemenu");

    }
    public void choose()
    {
        rockofpong.SetActive(true);
        game.SetActive(false);
    }
    public void chetlayquestions()
    {
        SceneManager.LoadScene("kamer1");
    }
    public void chetlayquestions2()
    {
        SceneManager.LoadScene("kamer2");
    }
    public void chetlayquestions3()
    {
        SceneManager.LoadScene("kamer3");
    }
}

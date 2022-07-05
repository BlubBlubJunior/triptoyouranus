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
        game.SetActive(false);
        
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
    public void chetlayquestions4()
    {
        SceneManager.LoadScene("chatleylast");
    }
    public void dalhiaquestions()
    {
        SceneManager.LoadScene("dalhia2");
    }
    public void dalhiaquestions2()
    {
        SceneManager.LoadScene("dalhia3");
    }
    public void daliaquestions3()
    {
        SceneManager.LoadScene("dalhia4");
    }
    public void daliaquestions4()
    {
        SceneManager.LoadScene("dalhia5");
    }
    public void gwenethquestions1()
    {
        SceneManager.LoadScene("gweneth2");
    }
    public void gwenethquestions2()
    {
        SceneManager.LoadScene("gweneth3");
    }
    public void gwenethquestions3()
    {
        SceneManager.LoadScene("gweneth4");
    }
    public void gwenethquestions4()
    {
        SceneManager.LoadScene("gweneth5");
    }
    public void ranni1hquestions4()
    {
        SceneManager.LoadScene("ranni2");
    }
    public void ranni2hquestions4()
    {
        SceneManager.LoadScene("ranni3");
    }
    public void ranni3hquestions4()
    {
        SceneManager.LoadScene("ranni4");
    }
    public void ranni4hquestions4()
    {
        SceneManager.LoadScene("ranni5");
    }
}

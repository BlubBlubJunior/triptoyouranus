using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class vraagbutton : MonoBehaviour
{
    public GameObject good;
    public int maxhearts = 1000;
    public int currenthearts = 0;

    public vraagbar Heartbar;
    
    void Start()
    {
        Heartbar.setmaxhearts(maxhearts);
    }

    void Update()
    {
        
    }
    public void playgame(int heart)
    {

        
        good.SetActive(false);
        currenthearts += heart;
        SceneManager.LoadScene("lobby");
    }
    void takedamage(int damage)
    {
        Heartbar.SetHearts(currenthearts);
    }
}

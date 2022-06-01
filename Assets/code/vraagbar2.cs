using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class vraagbar2 : MonoBehaviour
{
    public GameObject fout;
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
        SceneManager.LoadScene("lobby");

        fout.SetActive(false);
        currenthearts -= heart;
    }
    void takedamage(int damage)
    {
        Heartbar.SetHearts(currenthearts);
    }
}

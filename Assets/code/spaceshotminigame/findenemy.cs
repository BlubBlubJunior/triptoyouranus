using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class findenemy : MonoBehaviour
{
    public GameObject endgame;

    void Update()
    {
        if (GameObject.FindWithTag("enemy") == null)
        {
            SceneManager.LoadScene("lobby");
        }
    }
}
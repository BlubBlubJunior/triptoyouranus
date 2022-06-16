using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goal : MonoBehaviour
{
    public bool isplayergoal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            if (!isplayergoal)
            {
                Debug.Log("player 1 scored...");
                GameObject.Find("gamemanager").GetComponent<gamemanager>().player1scored();
               
            }
            else
            {
                Debug.Log("player 2 scored...");
                GameObject.Find("gamemanager").GetComponent<gamemanager>().player2scored();
                
            }
        }
    }
}

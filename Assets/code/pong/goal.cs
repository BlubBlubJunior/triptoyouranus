using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goal : MonoBehaviour
{
    public bool isPlayer1Goal;
    public int score = 0;
    public int score2 = 0;
    

    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.CompareTag("ball"))
        {
            if (!isPlayer1Goal)
            {
                Debug.Log("Player 1 Scored!");
                score += 1;
                GameObject.Find("GameManager").GetComponent<GameManager>().Player1Scored();
                
            }
            
            else
            {
                Debug.Log("Player 2 Scored!");
                score2 += 1;
                GameObject.Find("GameManager").GetComponent<GameManager>().Player2Scored();

            }
        }
    }
    public void Update()
    {
        if (score > 5)
        {
            SceneManager.LoadScene("lobby");
        }
        if (score2 > 5)
        {
            SceneManager.LoadScene("lobby");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gamemanager : MonoBehaviour
{
    public GameObject end;

    [Header("ball")]
    public GameObject ball;

    [Header("player1")]
    public GameObject player1paddle;
    public GameObject player1goal;

    [Header("player2")]
    public GameObject player2paddle;
    public GameObject player2goal;

    [Header("scoreUI")]
    public GameObject player1text;
    public GameObject player2text;

    private int Player1Score;
    private int Player2Score;

    public void player1scored()
    {
        Player1Score++;
        player1text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        resetPosition();
        
    }
    public void player2scored()
    {
        Player2Score++;
        player2text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        resetPosition();
    }

   
    private void resetPosition()
    {
        ball.GetComponent<ball>().Reset();
        player1paddle.GetComponent<paddle>().Reset();
        player2paddle.GetComponent<paddle>().Reset();
    }
    public void Update()
    {
        if (Player1Score == 5)
        {
            end.SetActive(false);
        }
        if (Player2Score == 5)
        {
            end.SetActive(false);
        }
    }
}

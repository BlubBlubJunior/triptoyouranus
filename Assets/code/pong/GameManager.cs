using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("ball")]
    public GameObject ball;

    [Header("player1")]
    public GameObject player1;
    public GameObject player1goal;

    [Header("player2")]
    public GameObject player2;
    public GameObject player2goal;

    [Header("score UI")]
    public GameObject player1text;
    public GameObject player2text;

    private int player1score;
    private int player2score;

    public void Player1Scored()
    {
        player1score++;
        player1text.GetComponent<TextMeshProUGUI>().text = player1score.ToString();
        ResetPosition();
    }
    public void Player2Scored()
    {
        player2score++;
        player2text.GetComponent<TextMeshProUGUI>().text = player2score.ToString();
        ResetPosition();
    }

    private void ResetPosition()
    {
        ball.GetComponent<ball>().Reset();
        player1.GetComponent<paddle>().Reset();
        player2.GetComponent<paddle>().Reset();

    }
}

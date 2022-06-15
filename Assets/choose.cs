using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choose : MonoBehaviour
{
    public void nextroom()
    {
        SceneManager.LoadScene("lobby");
    }
}

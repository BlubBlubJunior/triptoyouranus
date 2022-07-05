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
    public void ranni()
    {
        SceneManager.LoadScene("ranni1");
    }
    public void dalhia()
    {
        SceneManager.LoadScene("delhia1");
    }
    public void gweneth()
    {
        SceneManager.LoadScene("gweneth1");
    }
}

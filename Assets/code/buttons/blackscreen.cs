using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class blackscreen : MonoBehaviour
{
    public int timer = 30;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1;
        if (timer < 1)
        {
            SceneManager.LoadScene("text");
        }
    }
}

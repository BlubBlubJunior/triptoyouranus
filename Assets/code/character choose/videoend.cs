using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
public class videoend : MonoBehaviour
{

    public VideoPlayer VideoPlayer; 
    public GameObject blackscreen;
    void Start()
    {
        VideoPlayer.loopPointReached += LoadScene;
    }
    void LoadScene(VideoPlayer vp)
    {
        blackscreen.SetActive(true);
    }
}

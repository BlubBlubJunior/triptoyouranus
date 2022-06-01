using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class vraagbar : MonoBehaviour
{

    public Slider slider;

    public void setmaxhearts(int hearts)
    {
        slider.maxValue = hearts;
        slider.value = hearts;
    }
    public void SetHearts(int hearts)
    {
        slider.value = hearts;

    }
}

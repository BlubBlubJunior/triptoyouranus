using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class dialogos : MonoBehaviour
{
    public TextMeshProUGUI textcomponent;
    public string[] lines;
    public float textspeed;
    public GameObject next;
    public GameObject character;
    public GameObject character2;
    public GameObject name1;
    public GameObject name2;


    private int index;
    void Start()
    {
        textcomponent.text = string.Empty;
        startDailogo();
        character2.SetActive(false);
        name2.SetActive(false);


    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textcomponent.text == lines[index])
            {
                NextLine();
                
                character.SetActive(false);
                character2.SetActive(true);
                name1.SetActive(false);
                name2.SetActive(true);
            }
            else
            {
                StopAllCoroutines();
                textcomponent.text = lines[index];
            }
        }
    }

    void startDailogo()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textcomponent.text += c;
            yield return new WaitForSeconds(textspeed);
        }
    }
    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textcomponent.text = string.Empty;
            StartCoroutine(TypeLine());
            
        }
        else
        {
            next.SetActive(true);
            gameObject.SetActive(false);
            


        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DIalogueGrandpa : MonoBehaviour
{
    public Text textdisplay;
    public string[] sentences;
    public int index;
    public float typingSpeed;

    public GameObject NextButton;
    // Start is called before the first frame update
    public void Start()
    {
        StartCoroutine(Type());
        NextButton.SetActive(false);
    }

    public void Update()
    {
        if (textdisplay.text == sentences[index])
        {
            NextButton.SetActive(true);
        }
    }
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textdisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        NextButton.SetActive(false);

        if (index < sentences.Length - 1)
        {
            index++;
            textdisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textdisplay.text = "";
            NextButton.SetActive(false);
        }
    }
}

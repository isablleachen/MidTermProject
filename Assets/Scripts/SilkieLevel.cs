using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SilkieLevel : MonoBehaviour
{
    public GameObject sadine;
    public GameObject silkie;
    public GameObject buns;
    public GameObject bird;

    public Text textshowed;
    public Text textshowed2;
    // Start is called before the first frame update
    void Start()
    {
        sadine = GameObject.FindWithTag("sadine");
        buns = GameObject.FindWithTag("buns");
        bird = GameObject.FindWithTag("bird");
    }

    // Update is called once per frame
    void Update()
    {
        if (sadine.GetComponent<CheckEnterS>().EnteredTrigger)
        {
            Debug.Log("get sadine");
            textshowed.text = "DRUNKARD: Oh! A sadine can! I love it!";
            textshowed2.text = null; 
        }

        if (buns.GetComponent<CheckEnterS>().EnteredTrigger)
        {
            Debug.Log("get buns");
            textshowed.text = "DRUNKARD: What?! Steamed bun?";
            textshowed2.text = "NO. I'm sick of eating it.";
        }

        if (bird.GetComponent<CheckEnterS>().EnteredTrigger)
        {
            Debug.Log("get bird");
            textshowed.text = "DRUNKARD: This bird doesn't have much nutrition.";
            textshowed2.text = null;
        }
    }
}

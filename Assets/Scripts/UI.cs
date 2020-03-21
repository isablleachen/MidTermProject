using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject hen;
    public GameObject chubby;
    public GameObject silkie;

    public Image HenCheck;
    public Image SilkieCheck;
    public Image ChubbyCheck;
    public Image Win;

    public Sprite HenGreen;
    public Sprite SilkieGreen;
    public Sprite ChubbyGreen;

    public AudioSource bell;
    public AudioSource bell2;
    public AudioSource bell3;
    public AudioSource Congratulation;
    public AudioSource Success;

    public Text textshowed;
    public Text textshowed2;
    // Start is called before the first frame update
    void Start()
    {
        hen = GameObject.FindWithTag("hen");
        chubby = GameObject.FindWithTag("chubby");
        silkie = GameObject.FindWithTag("silkie");
        Win.enabled = false;
        bell.enabled = false;
        bell2.enabled = false;
        bell3.enabled = false;
        Success.enabled = false;
        Congratulation.enabled = false;
        textshowed.enabled = true;
        textshowed.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (hen.GetComponent<CheckEnter>().EnteredTrigger)
        { Debug.Log("hen is in the chickenhouse");
            HenCheck.sprite = HenGreen;
            bell.enabled = true;
        }

        if (chubby.GetComponent<CheckEnter>().EnteredTrigger)
        { Debug.Log("chubby is in the chickenhouse");
            ChubbyCheck.sprite = ChubbyGreen;
            bell2.enabled = true;
        }

        if (silkie.GetComponent<CheckEnter>().EnteredTrigger)
        { Debug.Log("silkie is in the chickenhouse");
            SilkieCheck.sprite = SilkieGreen;
            bell3.enabled = true;
        }

        if (silkie.GetComponent<CheckEnter>().EnteredTrigger && chubby.GetComponent<CheckEnter>().EnteredTrigger && hen.GetComponent<CheckEnter>().EnteredTrigger)
        {
            Debug.Log("quest complete");
            textshowed.enabled = false;
            textshowed2.enabled = false;
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        Win.enabled = true;
        Success.enabled = true;
        Congratulation.enabled = true;
        
    }

















}

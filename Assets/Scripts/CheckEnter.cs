using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckEnter : MonoBehaviour
{
  
    // Start is called before the first frame update
    public bool EnteredTrigger;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "chickenhouse")
         EnteredTrigger = true; 
    }
}

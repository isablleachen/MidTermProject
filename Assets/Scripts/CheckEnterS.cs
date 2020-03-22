using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckEnterS : MonoBehaviour
{
    public bool EnteredTrigger;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "table")
            EnteredTrigger = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestLevel : MonoBehaviour
{
    public GameObject Hen1;
    public GameObject Hen2;
    public GameObject Hen3;

    public float distanceToObject;
    public Text textshowed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (distanceToObject >= Vector3.Distance(this.transform.position, Hen1.transform.position) && distanceToObject >= Vector3.Distance(this.transform.position, Hen2.transform.position) && distanceToObject >= Vector3.Distance(this.transform.position, Hen3.transform.position))
        {
            
            textshowed.text = "Test Level complete!!";
           
        }
    }
}

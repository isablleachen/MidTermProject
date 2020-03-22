using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstPersonController : MonoBehaviour
{
    public CharacterController playercontroller;
    public float backforth;
    public float leftright;

    public float moveSpeed = 0.04f;
    public float mouseX, mouseY;

    public Vector3 inputVector;

    public GameObject Grandpa;
    public GameObject FemaleVillager;
    public GameObject Villager;
    public GameObject Statue;
    public GameObject Salesman;
    public GameObject oven;
    public GameObject desk;
    public GameObject CansPack;
    public GameObject Drunkard;
    public GameObject Painter;
    public GameObject Poster;
    public GameObject bird;
    public GameObject pig;
    public GameObject pighouse;
    public GameObject plant;
    public float distanceToObject;
    public float distanceToObject2;

    public Text textshowed = null;
    public Text textshowed2 = null;
    // Start is called before the first frame update
    void Start()
    {
        playercontroller = GetComponent<CharacterController>();
        textshowed.text = null;
        textshowed2.text = null;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(0, mouseX, 0);
        Camera.main.transform.Rotate(-mouseY, 0, 0);

        backforth = Input.GetAxis("Horizontal");
        leftright = Input.GetAxis("Vertical");

        inputVector = transform.forward * backforth;
        inputVector -= transform.right * leftright;

        playercontroller.Move(inputVector * moveSpeed + (Physics.gravity * .3f));

        if (distanceToObject >= Vector3.Distance(this.transform.position, Grandpa.transform.position))
        {
            Debug.Log("talk with grandpa");
            textshowed.text = "GRANDPA: Oh no! There must be some chicken ran away! ";
            textshowed2.text = "I don't think those chicken are still alive.";
        }

        if (distanceToObject >= Vector3.Distance(this.transform.position, bird.transform.position))
        {
            
            textshowed.text = "This is just a little bird, not a chicken.";
            textshowed2.text = null;
        }

        if (distanceToObject >= Vector3.Distance(this.transform.position, plant.transform.position))
        {

            textshowed.text = "The owner of this house loves succulent.";
            textshowed2.text = null;
        }

        if (distanceToObject >= Vector3.Distance(this.transform.position, pighouse.transform.position))
        {
            textshowed.text = "Villagers built this hoggery to raise pigs. ";
            textshowed2.text = null;
        }

        if (distanceToObject >= Vector3.Distance(this.transform.position, Poster.transform.position))
        {
            textshowed.text = "Such posters are pasted everywhere in the village.";
            textshowed2.text = "Consumerism trap.";
        }

        if (distanceToObject >= Vector3.Distance(this.transform.position, pig.transform.position))
        {
            textshowed.text = "A pig is admiring beautiful blossoms.";
            textshowed2.text = null;
        }

        if (distanceToObject >= Vector3.Distance(this.transform.position, Drunkard.transform.position))
        {
            textshowed.text = "Drunkard: Oh! I thought I can eat this silkie! ";
            textshowed2.text = "...Could you bring me something to eat?";
        }

        if (distanceToObject2 >= Vector3.Distance(this.transform.position, Statue.transform.position))
        {
            textshowed.text = "Our village is famous for raising chickens, so we have this statue.";
            textshowed2.text = null;
        }

        if (distanceToObject >= Vector3.Distance(this.transform.position, Villager.transform.position))
        {
            textshowed.text = "VILLAGER: YO ———— Kid, how's your midterm project going?";
            textshowed2.text = "Feeling good with 3D modeling?";
        }

        if (distanceToObject2 >= Vector3.Distance(this.transform.position, Painter.transform.position))
        {
            textshowed.text = "PAINTER: I don't want to draw it anymore, it's just stupid.";
            textshowed2.text = "Even a chicken will be laughing at me!";
        }

        if (distanceToObject >= Vector3.Distance(this.transform.position, CansPack.transform.position))
        {
            textshowed.text = "Someone orders dozens of sadines.";
            textshowed2.text = null;
        }

        if (distanceToObject >= Vector3.Distance(this.transform.position, desk.transform.position))
        {
            textshowed.text = "Geez. A hen has pooped on your homework!";
            textshowed2.text = "(if you want to pick up something, just hold on left key)";
        }

        if (distanceToObject >= Vector3.Distance(this.transform.position, oven.transform.position))
        {
            textshowed.text = "There's some steamed buns in the oven.";
            textshowed2.text = null;
        }

        if (distanceToObject >= Vector3.Distance(this.transform.position, FemaleVillager.transform.position))
        {
            textshowed.text = "VILLAGER: Today's weather is nice, I want my baby to get some sun.";
            textshowed2.text = "I didn't see any chicken this morning.";
        }

        if (distanceToObject >= Vector3.Distance(this.transform.position, Salesman.transform.position))
        {
            textshowed.text = "SALESMAN: Do you want any sadine cans? ";
            textshowed2.text = "These are all imported from Europe!";
        }
    }

    void FixedUpdate()
    {
        
    }
}

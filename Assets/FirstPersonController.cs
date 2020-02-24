using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    public Rigidbody playerrigidbody;
    public float backforth;
    public float leftright;

    public float moveSpeed = 2.5f;
    public float mouseX, mouseY;

    public Vector3 inputVector;
    // Start is called before the first frame update
    void Start()
    {
        playerrigidbody = GetComponent<Rigidbody>();
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
    }

    void FixedUpdate()
    {
        playerrigidbody.velocity = (inputVector * moveSpeed * Time.fixedDeltaTime * 50);
    }
}

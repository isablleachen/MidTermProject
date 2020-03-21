using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasting : MonoBehaviour
{
    public float maxRaycastDistance = 1000f;
    public GameObject paintBrush;
    public Camera Camera;
    // Update is called once per frame
    void Update()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        Debug.DrawRay(camRay.origin, camRay.direction * maxRaycastDistance, Color.cyan);

        RaycastHit hitObject;

        if (Physics.Raycast(camRay, out hitObject, maxRaycastDistance))
        {
            paintBrush.transform.position = hitObject.point;

            if (Input.GetMouseButton(0))
            {
                GameObject Paint = Instantiate(paintBrush, hitObject.point, Quaternion.identity);

                Paint.transform.SetParent(hitObject.transform);
            }


            //  hitObject.transform.Rotate(new Vector3(0, 0, 35 * Time.deltaTime));

        }
    }
}

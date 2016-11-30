using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour {


    float temp;
    bool isRotating;
    int horizontalDirection, verticalDirection;

    void FixedUpdate()
    {


        if (Input.GetButtonDown("RotateLeft") && !isRotating)
        {
            isRotating = true;
            horizontalDirection = 1;
            verticalDirection = 0;
            temp = 0;
        }
        if (Input.GetButtonDown("RotateRight") && !isRotating)
        {
            isRotating = true;
            horizontalDirection = -1;
            verticalDirection = 0;
            temp = 0;
        }
        if(Input.GetButtonDown("RotateLeft") && Input.GetButtonDown("RotateRight"))
        {
            isRotating = false;
            horizontalDirection = 0;
            verticalDirection = 0;
            temp = 0;
        }
        transform.Rotate(Vector3.up * 90 * Time.fixedDeltaTime * horizontalDirection, Space.World);
        transform.Rotate(Vector3.right * 90 * Time.fixedDeltaTime * verticalDirection, Space.World);
        temp += 90 * Time.fixedDeltaTime;
        if (temp >= 90)
        {
            temp = 0;
            horizontalDirection = 0;
            verticalDirection = 0;
            isRotating = false;
        }

    }
}

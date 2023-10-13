using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookX : MonoBehaviour
{
    public float rotationSpeed = 100.0f;
    public float sensitivity = 5.0f;

    void Update()
    {
        RotateCamera();
        lookX();
    }

    void RotateCamera()
    {
        float horizontal = 0.0f;
        float vertical = 0.0f;

       /* if (Input.GetKey(KeyCode.U)) vertical = 1.0f;
        else if (Input.GetKey(KeyCode.J)) vertical = -1.0f;*/

        if (Input.GetKey(KeyCode.H)) horizontal = -1.0f;
        else if (Input.GetKey(KeyCode.K)) horizontal = 1.0f;

        Vector3 currentRotation = transform.localRotation.eulerAngles;

        currentRotation.x += vertical * rotationSpeed * Time.deltaTime;
        currentRotation.y += horizontal * rotationSpeed * Time.deltaTime;

        currentRotation.x = Mathf.Clamp(currentRotation.x, -90f, 90f);

        transform.localRotation = Quaternion.Euler(currentRotation);
    }

    void lookX()
    {
        float mouseX = Input.GetAxis("Mouse X");

        Vector3 rot = transform.localEulerAngles;

        rot.y += mouseX * sensitivity;
        transform.localEulerAngles = rot;
    }
}

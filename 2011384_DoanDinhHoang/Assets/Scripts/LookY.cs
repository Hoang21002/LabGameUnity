using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookY : MonoBehaviour
{
    public float rotationSpeed = 100.0f;
    public float sensitivity = 5.0f;

    public float mouseY = 0.0f;
    public float sensitivityY = 2.0f;

    void Update()
    {
        RotateCamera();
        //lookX();
        lookY();
    }

    void RotateCamera()
    {
        float vertical = 0.0f;

        if (Input.GetKey(KeyCode.U)) vertical = -1.0f;
        else if (Input.GetKey(KeyCode.J)) vertical = 1.0f;

        Vector3 currentRotation = transform.localRotation.eulerAngles;

        currentRotation.x += vertical * rotationSpeed * Time.deltaTime;
        //currentRotation.x = Mathf.Clamp(currentRotation.x, -80.0f, 360.0f); // Đảm bảo giữ giá trị x trong khoảng -80 đến 360

        // Chỉ cập nhật giá trị x
        transform.localRotation = Quaternion.Euler(currentRotation.x, transform.localRotation.eulerAngles.y, transform.localRotation.eulerAngles.z);
    }

    void lookY()
    {
        mouseY = Input.GetAxis("Mouse Y") * sensitivityY;

        Vector3 rot = transform.localEulerAngles;

        rot.x -= mouseY;

        rot.x = Mathf.Clamp(rot.x, -80.0f, 360.0f);

        transform.localEulerAngles = rot;
    }
}

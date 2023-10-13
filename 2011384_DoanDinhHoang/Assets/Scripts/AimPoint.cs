using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimPoint : MonoBehaviour
{
    public float rotationSpeed = 100.0f;

    void Update()
    {
        // Thay đổi x và y của m_LocalRotation của camera khi người chơi ấn các phím U, H, J, K
        RotateCamera();
    }

    void RotateCamera()
    {
        float horizontal = 0.0f;
        float vertical = 0.0f;

        // Kiểm tra các phím được ấn
        if (Input.GetKey(KeyCode.U)) vertical = 1.0f;
        else if (Input.GetKey(KeyCode.J)) vertical = -1.0f;

        if (Input.GetKey(KeyCode.H)) horizontal = -1.0f;
        else if (Input.GetKey(KeyCode.K)) horizontal = 1.0f;

        // Lấy giá trị x và y hiện tại của m_LocalRotation
        Vector3 currentRotation = transform.localRotation.eulerAngles;

        // Thay đổi giá trị x và y
        currentRotation.x += vertical * rotationSpeed * Time.deltaTime;
        currentRotation.y += horizontal * rotationSpeed * Time.deltaTime;

        // Giới hạn giá trị x trong khoảng (-90, 90) để tránh camera quay quá đỉnh
        //currentRotation.x = Mathf.Clamp(currentRotation.x, -90f, 90f);

        // Gán giá trị mới vào m_LocalRotation
        transform.localRotation = Quaternion.Euler(currentRotation);
    }
}

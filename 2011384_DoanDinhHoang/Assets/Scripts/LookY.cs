using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookY : MonoBehaviour
{
    public float _mouseY = 0.0f;

    public float _sensitivity = 2.0f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        _mouseY = Input.GetAxis("Mouse Y") * _sensitivity;

        Vector3 rot = transform.localEulerAngles;

        rot.x -= _mouseY;

        rot.x = Mathf.Clamp(rot.x , -80.0f, 360.0f);

        transform.localEulerAngles = rot;
    }
}

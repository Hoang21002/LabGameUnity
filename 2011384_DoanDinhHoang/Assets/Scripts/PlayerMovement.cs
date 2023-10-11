using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController _characterController;
    public float _moveSpeed = 5.0f;

    public float _jumpSpeed = 40.0f;

    float _gravity = 1.0f;

    float _vVelocity = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 moveDirection =transform.TransformDirection(direction);
        Vector3 velocity = direction * _moveSpeed;
        if (_characterController.isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                _vVelocity = _jumpSpeed;
            }
        }
        else _vVelocity -= _gravity;
        velocity.y = _vVelocity;
        _characterController.Move(velocity*Time.deltaTime);
        /* _characterController.Move(velocity);*/
    }
}

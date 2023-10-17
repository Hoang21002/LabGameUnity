using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController _characterController;
    public float _moveSpeed = 8.0f;
    public float _shiftMoveSpeed = 12.0f; 
    public float _jumpSpeed = 12.0f;
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
        // Kiểm tra xem phím Shift có được ấn không
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            _moveSpeed = _shiftMoveSpeed;
        }
        else
        {
            _moveSpeed = 8.0f; // Nếu không ấn Shift, sử dụng tốc độ mặc định
        }

        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 moveDirection = transform.TransformDirection(direction);
        Vector3 velocity = moveDirection * _moveSpeed;

        if (_characterController.isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                _vVelocity = _jumpSpeed;
            }
        }
        else
        {
            _vVelocity -= _gravity;
        }

        velocity.y = _vVelocity;
        _characterController.Move(velocity * Time.deltaTime);
    }
}

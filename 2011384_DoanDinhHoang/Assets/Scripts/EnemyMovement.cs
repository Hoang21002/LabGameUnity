using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    CharacterController _controller;
    Transform _player;
    public float _moveSpeed = 5.0f;
    public float _gravity = 2.0f;
    float _yVelocity = 0.0f;
    void Start()
    {
        GameObject playerGameObject = GameObject.FindGameObjectWithTag("Player");
        _player = playerGameObject.transform;

        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 direction = _player.position - transform.position;
        direction.Normalize();

        Vector3 velocity = direction * _moveSpeed;

        if (!_controller.isGrounded)
        {
            _yVelocity -= _gravity;
        }
        velocity.y = _yVelocity;

        direction.y = 0;

        transform.rotation = Quaternion.LookRotation(direction);

        _controller.Move(velocity *  Time.deltaTime);


        direction.Normalize();


        _controller.Move(direction * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Joystick _joystick;
    private Animator _animator;
    private Rigidbody _rigidBody;
    [SerializeField]
    private float _jumpForce = 3f;
    [SerializeField]
    private float _animationSpeed = 1f;

    private bool _isJumping = false;

    void Start()
    {
        _animator = GetComponentInChildren<Animator>();
        _rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var moveDirection = _joystick.Direction;

        if(moveDirection != Vector2.zero)
        {
            transform.position += transform.forward * Time.deltaTime * moveDirection.y * 1.8f;
            transform.RotateAround(transform.position, transform.up, Time.deltaTime * moveDirection.x * 20f);

            _animator.SetBool("isRunning", true);
        }
        else
        {
            _animator.SetFloat("animationSpeed", _animationSpeed);
            _animator.SetBool("isRunning", false);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            _isJumping = true;
            _rigidBody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);

            _animator.SetBool("isJumping", _isJumping);
        }

    }
}

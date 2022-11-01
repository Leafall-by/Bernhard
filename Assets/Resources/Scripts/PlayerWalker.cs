using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerWalker : MonoBehaviour
{
    private float _speed;
    private Rigidbody _rb;
    private PlayerAnimator _playerAnimator;

    public void Init(float speed)
    {
        _speed = speed;
        _rb = GetComponent<Rigidbody>();

        _playerAnimator = GetComponent<PlayerAnimator>();
        _playerAnimator.Init();
    }

    private void FixedUpdate()
    {
        Run();
    }

    private void Run()
    {
        float horizontalX = Input.GetAxis("Horizontal");

        float horizontalY = Input.GetAxis("Vertical");

        _playerAnimator.StartRun(horizontalX, horizontalY);

        Vector3 movement = new Vector3(horizontalX, 0.0f, horizontalY);

        _rb.velocity = (movement * _speed);
    }
}

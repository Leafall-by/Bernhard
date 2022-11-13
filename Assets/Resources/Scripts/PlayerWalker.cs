using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerWalker : MonoBehaviour
{
    private float _speed;
    private PlayerAnimator _playerAnimator;

    public void Init(float speed)
    {
        _speed = speed;

        _playerAnimator = GetComponent<PlayerAnimator>();
        _playerAnimator.Init(speed);
    }

    private void FixedUpdate()
    {
        Run();
    }

    private void Run()
    {
        float horizontalX = Input.GetAxis("Horizontal");

        float horizontalY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalX, 0, horizontalY);

        transform.Translate(movement * _speed * Time.fixedDeltaTime);
    }
}

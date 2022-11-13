using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(PlayerAnimator))]
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

        float horizontalZ = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(horizontalX, 0, horizontalZ);
        
        float fixedSpeed = _speed * Time.fixedDeltaTime;
        
        _playerAnimator.StartRun(horizontalX * fixedSpeed * 10, horizontalZ * fixedSpeed * 10);

        transform.Translate(movement * fixedSpeed);
    }
}

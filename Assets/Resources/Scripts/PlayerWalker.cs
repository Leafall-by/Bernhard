using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerWalker : NetworkBehaviour
{
    private float _speed;

    public void Init(float speed)
    {
        _speed = speed;
        
    }

    private void FixedUpdate()
    {
        if (isLocalPlayer)
        {
            Run();   
        }
    }

    private void Run()
    {
        float horizontalX = Input.GetAxis("Horizontal");

        float horizontalZ = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(horizontalX, 0, horizontalZ);
        
        float fixedSpeed = _speed * Time.fixedDeltaTime;

        transform.Translate(movement * fixedSpeed);
    }
}

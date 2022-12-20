using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class PushedObject : NetworkBehaviour
{
    private Rigidbody _rigidbody;
    private NetworkIdentity i;
    
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    [Command(requiresAuthority = false)]
    public void Push()
    {
        ServerPush();
    }


    [Server]
    public void ServerPush()
    {
        
        _rigidbody.AddForce(Vector3.forward * 100, ForceMode.Impulse);
    }
}

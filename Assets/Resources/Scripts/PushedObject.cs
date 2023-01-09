using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PushedObject : NetworkBehaviour
{
    [SerializeField] private int pushForce;
    
    
    
    public void PushObject(Vector3 vector)
    {
        Debug.Log("1");
        
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(vector * pushForce, ForceMode.Impulse);
    }
}

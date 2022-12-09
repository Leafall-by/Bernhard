using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerDisableObjects : NetworkBehaviour
{
    [SerializeField] private Behaviour[] _objects;

    private void Update()
    {
        if (isLocalPlayer == false)
        {
            for (int i = 0; i < _objects.Length; i++)
            {
                _objects[i].enabled = false;
            }
        }
    }
}

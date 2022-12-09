using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

[RequireComponent (typeof(PlayerHealth), typeof(PlayerWalker))]
public class Player : NetworkBehaviour
{
    [SerializeField] private GameObject CameraMountPoint;
    [SerializeField] private int _speed;
    [SerializeField] private int _health;

    private PlayerHealth _playerHealth;
    private PlayerWalker _playerWalker;

    public void Start()
    {
        if (isLocalPlayer)
        {
            Transform cameraTransform = Camera.main.gameObject.transform;  //Find main camera which is part of the scene instead of the prefab
            Camera.main.transform.parent = CameraMountPoint.transform;
            cameraTransform.position = CameraMountPoint.transform.position;  //Set position/rotation same as the mount point
            cameraTransform.rotation = CameraMountPoint.transform.rotation;
        }
        
        _playerHealth = GetComponent<PlayerHealth>();
        _playerHealth.Init(_health);
        
        _playerWalker = GetComponent<PlayerWalker>();
        _playerWalker.Init(_speed);
    }
} 

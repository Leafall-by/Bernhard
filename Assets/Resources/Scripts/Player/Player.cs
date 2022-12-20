using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

[RequireComponent (typeof(PlayerHealth), typeof(PlayerWalker), typeof(PlayerShooter))]
public class Player : NetworkBehaviour
{
    [SerializeField] private int _speed;
    [SerializeField] private int _health;

    private PlayerHealth _playerHealth;
    private PlayerWalker _playerWalker;
    private PlayerShooter _playerShooter;

    public void Start()
    {
        _playerHealth = GetComponent<PlayerHealth>();
        _playerHealth.Init(_health);
        
        _playerWalker = GetComponent<PlayerWalker>();
        _playerWalker.Init(_speed);

        _playerShooter = GetComponent<PlayerShooter>();
    }

    private void Update()
    {
        if (isLocalPlayer == false)
            return;

        if (Input.GetMouseButtonDown(0))
        {
            _playerShooter.Shoot();
        }
    }
} 

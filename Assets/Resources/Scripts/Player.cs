using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

[RequireComponent (typeof(PlayerHealth), typeof(PlayerWalker))]
public class Player : NetworkBehaviour
{
    [SerializeField] private int _speed;
    [SerializeField] private int _health;

    private PlayerHealth _playerHealth;
    private PlayerWalker _playerWalker;

    public void Start()
    {
        _playerHealth = GetComponent<PlayerHealth>();
        _playerHealth.Init(_health);
        
        _playerWalker = GetComponent<PlayerWalker>();
        _playerWalker.Init(_speed);
    }
} 

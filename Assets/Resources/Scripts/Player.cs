using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(PlayerHealth), typeof(PlayerWalker))]
public class Player : MonoBehaviour
{
    private PlayerHealth _playerHealth;
    private PlayerWalker _playerWalker;

    public void Init(int health, int speed)
    {
        _playerHealth = GetComponent<PlayerHealth>();
        _playerHealth.Init(health);

        _playerWalker = GetComponent<PlayerWalker>();
        _playerWalker.Init(speed);
    }
}

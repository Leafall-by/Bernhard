using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    [SerializeField] private Weapon weapon;

    public void Shoot()
    {
        weapon.Shoot();
    }
}

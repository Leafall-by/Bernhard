using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamageable
{
    private int _health;

    public void GetDamage()
    {
        Debug.Log("f");
    }

    public void Init(int health)
    {
        _health = health;
    }
}

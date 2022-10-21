using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private int _health;

    public void Init(int health)
    {
        _health = health;
    }
}

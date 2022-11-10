using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

internal class Bullet : MonoBehaviour
{
    private int _damage;

    public void Init(int damage)
    {
        _damage = damage;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("FFF");
    }


}


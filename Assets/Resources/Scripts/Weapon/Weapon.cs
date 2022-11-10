using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;

    [SerializeField] private int _damage;

    [SerializeField] private int _maxAmmo;
    protected int _currentAmmo;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        Bullet bullet = Instantiate(_bulletPrefab).GetComponent<Bullet>();
        bullet.Init(_damage);
        bullet.gameObject.GetComponent<Rigidbody>().AddForce(0, 0, 100);
    }

    abstract public void Reload();
}

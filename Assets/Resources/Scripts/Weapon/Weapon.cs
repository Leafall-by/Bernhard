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
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));

        if (Physics.Raycast(ray, out hit))
        {
            hit.rigidbody.AddForce(-hit.normal * 100, ForceMode.Impulse);
        }
    }

    abstract public void Reload();
}

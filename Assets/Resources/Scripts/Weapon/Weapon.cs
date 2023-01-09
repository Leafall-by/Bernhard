using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public abstract class Weapon : NetworkBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;

    [SerializeField] private int _damage;

    [SerializeField] private int _maxAmmo;
    protected int _currentAmmo;
    
    
    public void Shoot()
    {
        Vector3 bulletPosition = Camera.main.transform.position;
        Quaternion bulletQuaternion = Camera.main.transform.rotation;

        CmdSpawnBullet(bulletPosition, bulletQuaternion);
    }

    [Command(requiresAuthority = false)]
    private void CmdSpawnBullet(Vector3 position, Quaternion quaternion)
    {
        GameObject bullet = Instantiate(_bulletPrefab, position, quaternion);
        NetworkServer.Spawn(bullet);
    }

    abstract public void Reload();
}

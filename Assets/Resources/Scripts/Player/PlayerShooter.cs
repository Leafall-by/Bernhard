using Mirror;
using UnityEngine;

public class PlayerShooter : NetworkBehaviour
{
    [SerializeField] private GameObject _weaponPrefab;
    [SerializeField] private Transform _place;
    
    private Weapon weapon;

    [SyncVar]
    public GameObject weaponObject;

    [Command(requiresAuthority = false)]
    public void Init()
    {
        CmdCreateWeapon();
    }

    [Server]
    private void CmdCreateWeapon()
    {
        weaponObject = Instantiate(_weaponPrefab);
        Debug.Log(weaponObject == null ? "yes" : "no");
        NetworkServer.Spawn(weaponObject);
        SetWeaponAtPosition(weaponObject);
    }

    private void SetWeaponAtPosition(GameObject weaponObject)
    {
        weaponObject.transform.position = _place.transform.position;
        weaponObject.transform.rotation = _place.transform.rotation;
    }

    private void Update()
    {
        if (isLocalPlayer == false)
            return;

        if (Input.GetMouseButtonDown(0))
        {
            weapon.Shoot();
        }
    }
}
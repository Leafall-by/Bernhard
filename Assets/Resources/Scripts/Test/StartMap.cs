using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMap : NetworkBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;

    public void StartSession()
    {
        CmdStartSession(new Vector3(), new Quaternion());
    }
    
    [Command(requiresAuthority = false)]
    private void CmdStartSession(Vector3 position, Quaternion quaternion)
    {
        GameObject bullet = Instantiate(_bulletPrefab, position, quaternion);
        NetworkServer.Spawn(bullet);
    }
}

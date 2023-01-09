using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class TestCube : NetworkBehaviour
{
    [SerializeField] private GameObject _prefab;

    public void Init()
    {
        CmdSetPosition();
    }

    [Command(requiresAuthority = false)]
    private void CmdSetPosition()
    {
        GameObject cube = Instantiate(_prefab);
        NetworkServer.Spawn(cube);
        cube.transform.position = new Vector3(100, 0, 0);
        
        RpcSetPosition(cube);
    }

    [ClientRpc]
    private void RpcSetPosition(GameObject cube)
    {
        cube.transform.position = new Vector3(100, 0, 0);
    }
}

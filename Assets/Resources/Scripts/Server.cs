using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Mirror;
using UnityEngine;

public class Server : NetworkManager
{
    [Header("Settings")]
    [SerializeField] private GameObject clientPrefab;

    public override void OnStartServer()
    {
        base.OnStartServer();
        NetworkServer.RegisterHandler<PosMessage>(SpawnPlayer);
    }

    private void SpawnPlayer(NetworkConnectionToClient conn, PosMessage message)
    {
        GameObject hero = Instantiate(clientPrefab);
        NetworkServer.AddPlayerForConnection(conn, hero);
    }

    public override void OnClientConnect()
    {
        base.OnClientConnect();
        PosMessage message = new PosMessage();
        NetworkClient.Send(message);
    }
}

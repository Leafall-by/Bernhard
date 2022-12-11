using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerItem
{
    public string ServerName { get; set; }
    public int PlayerCount { get; set; }
    public int MaxPlayerCount { get; private set; }

    public ServerItem(string name, int playerCount, int maxPlayerCount)
    {
        ServerName = name;
        PlayerCount = playerCount;
        MaxPlayerCount = maxPlayerCount;
    }
}

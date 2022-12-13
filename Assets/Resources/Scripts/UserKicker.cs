using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class UserKicker : MonoBehaviour
{
    public static void DisconnectPlayer(NetworkConnection target)
    {
        target.Disconnect();
        NetworkManager.Destroy(target.identity.gameObject);
        
    }
}

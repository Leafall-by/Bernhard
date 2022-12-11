using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ServerList : MonoBehaviour
{
    private List<ServerItem> _serverItems;
    private Transform _list;

    private void Start()
    {
        _serverItems = new List<ServerItem>();
        _list = this.gameObject.transform;
        
        ShowServers();
    }

    public void AddServer(ServerItem server)
    {
        
    }

    private void ShowServers()
    {
        DeleteServersInUI();
        
        for (int i = 0; i < _serverItems.Count; i++)
        {
            
        }
    }

    private void DeleteServersInUI()
    {
        foreach (Transform children in _list)
        {
            Destroy(children.gameObject);
        }
    }

    private void CreateServerUI(ServerItem server)
    {
        
    }
}

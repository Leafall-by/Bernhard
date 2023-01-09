using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;
using TMPro;

public class PlayerCounter : NetworkBehaviour, PlayerCounterHandler
{
    [SyncVar]
    private int _playerCount = 0;

    private TextMeshProUGUI _text;

    private void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    [Command(requiresAuthority = false)]
    public void CmdSetCountPlayers(int count)
    {
        _playerCount = count;
        _text.text = _playerCount.ToString();
    }
}

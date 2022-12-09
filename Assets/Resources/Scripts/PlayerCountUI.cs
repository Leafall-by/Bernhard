using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCountUI : MonoBehaviour
{
    private TextMeshProUGUI _text;
    private void Start()
    {
        _text = this.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        _text.text = Server._playerNumber.ToString();
    }
}

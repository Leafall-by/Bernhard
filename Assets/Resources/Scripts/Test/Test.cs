using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject transform1;

    private void Start()
    {
        Camera.main.transform.parent = transform1.transform;
    }
}

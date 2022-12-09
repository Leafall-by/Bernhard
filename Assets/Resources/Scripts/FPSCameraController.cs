using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using Unity.VisualScripting;
using UnityEngine;

public class FPSCameraController : MonoBehaviour
{
    [SerializeField] private float _sensivity;
    [SerializeField] private Transform _player;
    [SerializeField] private float _verticalLover;
    [SerializeField] private float _verticalUpper;
    private float _currentVerticalAngle;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    //TODO Перенести прицел в отдельный класс
    private void OnGUI()
    {
        Vector3 vector = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        int size = 12;
        GUI.Label(new Rect(vector, new Vector2(size, size)), "*");
    }

    private void Update()
    {
        Rotate();
    }

    public void Rotate()
    {
        var vertical = -Input.GetAxis("Mouse Y") * _sensivity * Time.deltaTime;
        var horizontal = Input.GetAxis("Mouse X") * _sensivity * Time.deltaTime;

        _currentVerticalAngle = Mathf.Clamp(_currentVerticalAngle + vertical, _verticalUpper, _verticalLover);
        transform.localRotation = Quaternion.Euler(_currentVerticalAngle, 0, 0);
        _player.Rotate(0, horizontal, 0);
    }
}

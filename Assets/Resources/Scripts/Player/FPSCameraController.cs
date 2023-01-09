using System;
using Mirror;
using UnityEngine;

public class FPSCameraController : MonoBehaviour
{
    [SerializeField] private GameObject cameraMountPoint;
    [SerializeField] private float sensivity;
    [SerializeField] private Transform player;
    [SerializeField] private float verticalLover;
    [SerializeField] private float verticalUpper;
    private float _currentVerticalAngle;
    private NetworkBehaviour _playerNetwork;
    
    public void Init()
    {
        _playerNetwork = GetComponentInParent<NetworkBehaviour>();

        if (_playerNetwork.isLocalPlayer == false)
            return;

        PlaceCamera();
        
        HideCursor();
    }

    private void PlaceCamera()
    {
        try
        {
            CheckCamera();
        }
        catch (CameraNotFoundException ex)
        {
           //UserKicker.DisconnectPlayer(_playerNetwork.connectionToClient);
           Debug.Log(ex.Message);
        }
        
        Transform cameraTransform = Camera.main.gameObject.transform;
        Camera.main.transform.parent = cameraMountPoint.transform;
        cameraTransform.position = cameraMountPoint.transform.position;
        cameraTransform.rotation = cameraMountPoint.transform.rotation;
    }

    private void HideCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void CheckCamera()
    {
        if (Camera.main == null)
        {
            throw new CameraNotFoundException("Camera not found");
        }
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
        try
        {
            if (_playerNetwork.isLocalPlayer)
            {
                Rotate();   
            }
        }
        catch (NullReferenceException e)
        {
            this.enabled = false;
        }
    }

    public void Rotate()
    {
        var vertical = -Input.GetAxis("Mouse Y") * sensivity * Time.deltaTime;
        var horizontal = Input.GetAxis("Mouse X") * sensivity * Time.deltaTime;

        _currentVerticalAngle = Mathf.Clamp(_currentVerticalAngle + vertical, verticalLover, verticalUpper);
        transform.localRotation = Quaternion.Euler(_currentVerticalAngle, 0, 0);
        player.Rotate(0, horizontal, 0);
    }
}

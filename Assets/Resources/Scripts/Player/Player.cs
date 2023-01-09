using Mirror;
using UnityEngine;

[RequireComponent(typeof(PlayerHealth), typeof(PlayerWalker), typeof(PlayerShooter))]
public class Player : NetworkBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private int health;

    private PlayerHealth _playerHealth;
    private PlayerWalker _playerWalker;
    private PlayerShooter _playerShooter;


    public override void OnStartClient()
    {
        if (isLocalPlayer == false)
        {
            return;
        }
        
        _playerHealth = GetComponent<PlayerHealth>();
        _playerHealth.Init(health);
        
        _playerWalker = GetComponent<PlayerWalker>();
        _playerWalker.Init(speed);
        
        _playerShooter = GetComponent<PlayerShooter>();
        _playerShooter.Init();

        GetComponentInChildren<FPSCameraController>().Init();
    }
}

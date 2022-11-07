using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator _animator;
    private float _speedAnimation;
    private float velocity = 0;
    public void Init(float speedAnimation)
    {
        _animator = GetComponent<Animator>();
        _speedAnimation = speedAnimation;
    }

    public void StartRun(float speedX, float speedZ)
    {
        if (speedX != 0 || speedZ != 0)
        {
            _animator.SetBool("RunActive", true);

            velocity += Time.deltaTime * _speedAnimation / 10;
            velocity = velocity > 1 ? 1 : velocity;
            _animator.SetFloat("Blend", velocity);
        }
        else
        {
            _animator.SetBool("RunActive", false);
            
            velocity -= Time.deltaTime * _speedAnimation / 10;
            velocity = velocity < 0 ? 0 : velocity;
            _animator.SetFloat("Blend", velocity);
        }
    }
}

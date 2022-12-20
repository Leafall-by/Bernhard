using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator _animator;
    private float _speedAnimation;
    public void Init(float speedAnimation)
    {
        _animator = GetComponent<Animator>();
        _speedAnimation = speedAnimation;
    }

    public void StartRun(float speedX, float speedZ)
    {
        _animator.SetBool("Running", speedX != 0 || speedZ != 0);

       _animator.SetFloat("Velocity X", speedZ);
       _animator.SetFloat("Velocity Z", speedX);
    }
}

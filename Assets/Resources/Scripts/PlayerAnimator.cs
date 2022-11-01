using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator _animator;

    public void Init()
    {
        _animator = GetComponent<Animator>();
    }

    public void StartRun(float speedX, float speedZ)
    {
        if (speedX != 0 || speedZ != 0)
        {
            _animator.SetBool("RunActive", true);
        }
        else
        {
            _animator.SetBool("RunActive", false);
        }
    }
}

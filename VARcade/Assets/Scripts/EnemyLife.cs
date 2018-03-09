using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : CaracLife
{ 

    Animator animator;

    protected new void Awake()
    {
        base.Awake();
        animator = GetComponent<Animator>();
    }

    public new void TakeHit()
    {
        if (isAlive)
        {
            isAlive = false;
            animator.SetTrigger("Dead");
            Destroy(gameObject, 0.5f);
        }
    }
}

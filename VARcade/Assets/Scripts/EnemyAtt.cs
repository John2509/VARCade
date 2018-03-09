using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAtt : MonoBehaviour
{
    PlayerLife playerLife;
    Animator animator;

    void Awake ()
    {
        playerLife = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLife>();
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Escudo"))
        {
            playerLife.TakeHit();
            animator.SetTrigger("PlayerDead");
        }
    }
}

using UnityEngine;
using System.Collections;

public class EnemyMov : MonoBehaviour
{
    Transform playerTransform;
    PlayerLife playerLife;
    EnemyLife enemyLife;      
    UnityEngine.AI.NavMeshAgent nav;   


    void Awake()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerTransform = player.transform;
        playerLife = player.GetComponent<PlayerLife>();
        enemyLife = GetComponent<EnemyLife>();
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }


    void Update()
    {
        if (enemyLife.IsAlive() && playerLife.IsAlive())
        {
            nav.SetDestination(playerTransform.position);
        }
        else
        {
            nav.enabled = false;
        }
    }
}

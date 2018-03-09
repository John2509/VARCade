using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtt : MonoBehaviour {

    public float tempoEntreTiros = 0.15f;
    public float range = 50f;

    float timer;
    Ray shootRay;
    RaycastHit shootHit;
    int shootableMask;

    void Awake ()
    {
        timer = 0f;
        shootableMask = LayerMask.GetMask("Shootable");
    }
	
	void Update () {
        timer += Time.deltaTime;

        if (timer > tempoEntreTiros)
        {
            Shoot();
        }
	}

    private void Shoot()
    {
        timer = 0f;

        shootRay.origin = transform.position;
        shootRay.direction = transform.forward;

        if (Physics.Raycast(shootRay, out shootHit, range, shootableMask))
        {
            EnemyLife enemyLife = shootHit.collider.GetComponent<EnemyLife>();

            if (enemyLife != null)
            {
                enemyLife.TakeHit();
            }
        }
    }
}

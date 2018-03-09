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
    Camera cam;
    AudioSource audioSource;

    void Awake ()
    {
        timer = 0f;
        shootableMask = LayerMask.GetMask("Shootable");
        cam = GetComponentInChildren<Camera>();
        audioSource = GetComponent<AudioSource>();
        shootRay.origin = cam.transform.position;
        shootRay.direction = cam.transform.forward * range;
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

        shootRay.origin = cam.transform.position;
        shootRay.direction = cam.transform.forward*range;

        if (Physics.Raycast(shootRay, out shootHit, range, shootableMask))
        {
            EnemyLife enemyLife = shootHit.collider.GetComponent<EnemyLife>();

            if (enemyLife != null && enemyLife.IsAlive())
            {
                enemyLife.TakeHit();
                audioSource.Play();
            }
        }
    }
}

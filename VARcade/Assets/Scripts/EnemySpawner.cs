using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject enemy;
    public float tempoDeSpanw = 1f;
    public float meiaVidaDoTempo = 10f;
    public float variaçãoDoTempo = 0.5f;
    public float raioDeSpanw = 25f;
    public float raioDeSeguranca = 10f;

    PlayerLife playerLife;
    float timer;

	void Start () {
		if (raioDeSeguranca > raioDeSpanw)
        {
            throw new UnityException();
        }
        playerLife = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLife>();
        InvokeRepeating("Spawn", tempoDeSpanw, tempoDeSpanw);
        timer = 0f;
    }

    private void Update ()
    {
        timer += Time.deltaTime;

        if (timer >= meiaVidaDoTempo)
        {
            tempoDeSpanw *= variaçãoDoTempo;
            InvokeRepeating("Spawn", tempoDeSpanw, tempoDeSpanw);
            timer = 0f;
        }
    }

    void Spawn () {
		if (playerLife.IsAlive())
        {
            float x = Random.Range (-1f, 1f);
            float z = Random.Range (-1f, 1f);
            Vector3 dir = new Vector3(x, 0f, z);
            dir = dir.normalized * Random.Range(raioDeSeguranca, raioDeSpanw);

            Instantiate(enemy, gameObject.transform.position + dir, gameObject.transform.rotation);
        }
	}
}

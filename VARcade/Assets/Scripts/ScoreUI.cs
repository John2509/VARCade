using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreUI : MonoBehaviour {

    public static int pontuacao;

    Text text;
    PlayerLife playerLife;

	void Awake () {
        text = GetComponentInChildren<Text>();
        playerLife = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLife>();
        pontuacao = 0;
        InvokeRepeating("AumentaPontuacao", 1f, 1f);
    }
	
	void Update () {
        text.text = "Tempo: " + pontuacao;
	}

    void AumentaPontuacao ()
    {
        if (playerLife.IsAlive())
            pontuacao += 1;
    }
}

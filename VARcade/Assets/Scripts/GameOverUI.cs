using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverUI : MonoBehaviour {

    PlayerLife playerLife;
    bool GameOver;

    private void Awake()
    {
        playerLife = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLife>();
        GameOver = false;
    }

    void Update ()
    {
		if (!playerLife.IsAlive() && !GameOver)
        {
            GetComponent<Canvas>().enabled = true;
            GameOver = true;
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
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
            GetComponentInChildren<Image>().enabled = true;
            GetComponentInChildren<Text>().enabled = true;
            GameOver = true;
        }
	}
}

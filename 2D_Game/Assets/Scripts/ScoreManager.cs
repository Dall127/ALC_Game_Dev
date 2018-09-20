﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class ScoreManager : MonoBehaviour {
    public static int score;
    Text ScoreText;

	// Use this for initialization
	void Start () {
        ScoreText = GetComponent<Text>();
        score = 0;
	}

    // Update is called once per frame
    void Update()
    {
        if (score < 0) {
            score = 0;
        }
        ScoreText.text = " " + score;
	}
    public static void AddPoints (int pointsToAdd) {
        score += pointsToAdd;

    }
}

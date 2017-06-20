﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScoreDisplay : MonoBehaviour {

	ScoreAbsorber scoreAbsorber;
	Text text;
	// Use this for initialization
	void Start () {
		scoreAbsorber = FindObjectOfType<ScoreAbsorber>();
		text = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		text.text = "Score:" + scoreAbsorber.score;
	}
}

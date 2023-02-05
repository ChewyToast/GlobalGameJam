using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
	[SerializeField] private GameObject	restartCanvas;
	public	static long scoreValue;
	Text	score;

	private void Start() {
		scoreValue = 0;
		score = GetComponent<Text>();
	}

	private void Update() {
		if (!restartCanvas.activeInHierarchy)
			score.text = "" + scoreValue;
	}
}

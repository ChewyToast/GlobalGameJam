using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintScoreValue : MonoBehaviour
{
	private void Start() {
		Text score = GetComponent<Text>();
		score.text = "" + ScoreCounter.scoreValue;
	}
}

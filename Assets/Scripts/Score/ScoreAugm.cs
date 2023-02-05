using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAugm : MonoBehaviour
{
	public void OnTriggerEnter(Collider collision){
		if (collision.tag.Equals("Obj")
			&& ScoreCounter.scoreValue < 9999999999999999
			&& ScoreCounter.scoreValue > -1) {
			ScoreCounter.scoreValue += 1;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootMovment : MonoBehaviour
{
	Vector3	augm;

	void Start () {
		if (DifSelection.menuSelection <= 1) {
			augm = new Vector3(0f, -0.5f, 0f);
			InvokeRepeating("Move", 0.00f, 0.17f);
		}
		else if (DifSelection.menuSelection == 2)
		{
			augm = new Vector3(0f, -0.5f, 0f);
			InvokeRepeating("Move", 0.00f, 0.085f);
		}
		else if (DifSelection.menuSelection >= 3)
		{
			augm = new Vector3(0f, -0.5f, 0f);
			InvokeRepeating("Move", 0.00f, 0.045f);
		}
	}

	public void OnTriggerStay(Collider collision){
		if (collision.tag.Equals("Destroyer"))
			Destroy(gameObject);
	}

	void Move () {
		transform.position += augm;
	}
}

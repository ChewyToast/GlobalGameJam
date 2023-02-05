using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackTutorial : MonoBehaviour
{
	public GameObject	toDissable;
	public GameObject	toEnable;

	public void Back() {
		toDissable.SetActive(false);
		toEnable.SetActive(true);
	}
}

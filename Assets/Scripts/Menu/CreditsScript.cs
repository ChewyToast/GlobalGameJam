using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsScript : MonoBehaviour
{
	public GameObject	toDissable;
	public GameObject	toEnable;
	public GameObject	toEnable1;
	public GameObject	toEnable2;

	public void BackMenu() {
		toDissable.SetActive(false);
		toEnable.SetActive(true);
		toEnable1.SetActive(true);
		toEnable2.SetActive(true);
	}
}

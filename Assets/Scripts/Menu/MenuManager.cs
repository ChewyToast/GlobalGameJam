using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
	public GameObject	toDissable;
	public GameObject	toDissable1;
	public GameObject	toDissable2;
	// public GameObject	toDissable3;
	public GameObject	toEnable;
	public GameObject	toEnable2;

	public void Siguiente() {
		toDissable.SetActive(false);
		toEnable.SetActive(true);
	}

	public void Creditos() {
		toDissable.SetActive(false);
		toDissable1.SetActive(false);
		toDissable2.SetActive(false);
		// toDissable3.SetActive(false);
		toEnable2.SetActive(true);
	}

	public void Salir() {
		Application.Quit();
	}
}

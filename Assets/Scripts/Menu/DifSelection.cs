using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifSelection : MonoBehaviour
{
	public GameObject	toDissable;
	public GameObject	toEnable;
	public GameObject	toEnable2;
	public static int	menuSelection = 0;

	public void BackMenu() {
		toDissable.SetActive(false);
		toEnable.SetActive(true);
	}

	public void Tutorial() {
		toDissable.SetActive(false);
		toEnable2.SetActive(true);
	}

	public void Eazy() {
		menuSelection = 1;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void Hard() {
		menuSelection = 2;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void Impossible() {
		menuSelection = 3;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}

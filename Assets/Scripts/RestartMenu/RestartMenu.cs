using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{
	public void Jugar() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void Menu() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}

	public void Salir() {
		Application.Quit();
	}
}

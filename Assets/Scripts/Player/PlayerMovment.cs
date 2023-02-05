using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
	Animator	anima;
	Transform	pos;
	Rigidbody	rg;
	[SerializeField] private GameObject	restartCanvas;

	private void Start () {
		anima = this.gameObject.GetComponent<Animator>();
		rg = this.gameObject.GetComponent<Rigidbody>();
	}

	private void Update() {
		// ALLWAYS RESTART THE TRIGGERS
		anima.ResetTrigger("JumpTrigg");
		anima.ResetTrigger("DuckTrigg");

		// CHECK IF SOME KEY IS PRESSED
		if (!Input.GetKeyDown(KeyCode.LeftShift))
			{anima.ResetTrigger("ReleaseTrigg");}
		if (Input.GetKeyUp(KeyCode.LeftShift))
			{anima.SetTrigger("ReleaseTrigg");}
		if (Input.GetKey("space"))
			{anima.SetTrigger("JumpTrigg");}
		if (Input.GetKeyDown(KeyCode.LeftShift))
			{anima.SetTrigger("DuckTrigg");}
	}

	public void OnTriggerEnter(Collider collision){
		if (collision.tag.Equals("Obj")) {
			restartCanvas.SetActive(true);
			Destroy(gameObject);
		}
	}

	private IEnumerator WaitBeforeShow() {
		yield return new WaitForSeconds(3);
		Application.Quit();
		Debug.Log("END GAME!");
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FindController : MonoBehaviour {
	public Text textfield;
	SceneManager sceneManager;

	// Use this for initialization
	void Start () {
		GameObject gameController = GameObject.Find ("GameController");
		IncomeScript incomeScript = gameController.GetComponent<IncomeScript> ();

		Debug.Log ("end game controller will change text");

		if (incomeScript.getWon ()) {
			textfield.text = "You WON !!!";
		} else {
			textfield.text = "You LOST!";
		}
	}

	public void returnHomeButtonPressed(){
		SceneManager.LoadScene("startScreen");
	}

}

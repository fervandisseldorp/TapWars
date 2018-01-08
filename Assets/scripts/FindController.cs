using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindController : MonoBehaviour {
	public Text textfield;

	// Use this for initialization
	void Start () {
		GameObject gameController = GameObject.Find ("GameController");
		IncomeScript incomeScript = gameController.GetComponent<IncomeScript> ();


		if (incomeScript.getWon ()) {
			textfield.text = "You WON !!!";
		} else {
			textfield.text = "You LOST NOOB !";
		}
	}

}

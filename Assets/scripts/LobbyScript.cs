using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyScript : MonoBehaviour {


	public void goToWaitingScreen(){
		Debug.Log ("moving to waiting screen");

		Application.LoadLevel ("WaitingForOpponent");
	}
}

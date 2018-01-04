using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour {
	public GameObject abilityPanel;

	// Use this for initialization
	void Start () {
		// Set Screen to landscape.
		Screen.orientation = ScreenOrientation.LandscapeRight;

		// Set Camera height depending on Screen resolution.
		//float aspectRatio = (float) Screen.height / Screen.height;
		//Debug.Log ("ratio is " + aspectRatio);


	}

}

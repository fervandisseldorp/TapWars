using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyByContact : MonoBehaviour {
	public Text livesText;



	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Wall")
		{
			return;
		}
		Destroy(other.gameObject);
		setLivesText ();
	}

	void setLivesText(){
		livesText.text = "test";

	}
}

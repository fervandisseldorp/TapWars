using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyByContact : MonoBehaviour {
	public GameObject gameController;
	private IncomeScript incomeScript;

	void Start(){
		incomeScript = gameController.GetComponent<IncomeScript> ();
	}

	void OnTriggerEnter(Collider other) 
	{
		Debug.Log (other);
		if (other.tag == "Wall")
		{
			return;
		}
		if (other.tag == "Monster") {
			Debug.Log ("destroying the monster and substracting live");
			Destroy(other.gameObject);

			incomeScript.substractLive ();
		}
	}
		
}

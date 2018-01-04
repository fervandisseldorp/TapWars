using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyByContact : MonoBehaviour {


	void OnTriggerEnter(Collider other) 
	{
		Debug.Log (other);
		if (other.tag == "Wall")
		{
			return;
		}
		Debug.Log ("destroying the other object");
		Destroy(other.gameObject);
	}
		
}

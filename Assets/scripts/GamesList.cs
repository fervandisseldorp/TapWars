using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamesList : MonoBehaviour {
	//private ObjectPool buttonObjectPool;

	int[] roomsList = {0,1,2,3};

	// Use this for initialization
	void Start () {
		Debug.Log ("looping and showing rooms");
		for(int i=0; i<roomsList.Length; i++){

			int roomNr = roomsList [i];

			//GameObject newButton = buttonObjectPool.GetObject();
			//newButton.transform.SetParent(contentPanel);

			//SampleButton sampleButton = newButton.GetComponent<SampleButton>();
			//sampleButton.Setup(item, this);

		}
	}





}

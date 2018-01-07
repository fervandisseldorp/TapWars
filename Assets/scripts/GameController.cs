using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;

public class GameController : MonoBehaviour {
	public int lives;
	//private SocketIOComponent socket;
	GameObject socketObject;


	// Use this for initialization
	void Start () {
		
	}

	void Update()
	{
		if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
		{
			Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			RaycastHit raycastHit;
			if (Physics.Raycast(raycast, out raycastHit))
			{
				Debug.Log("Something Hit");
				if (raycastHit.collider.CompareTag("Monster"))
				{
					Debug.Log("Monster clicked");
				}
			}
		}

		if(Input.GetMouseButtonDown(0)){
			Debug.Log ("mouse button pressed");

			Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			RaycastHit raycastHit;
			if (Physics.Raycast(raycast, out raycastHit))
			{
				Debug.Log("Something Hit");
				if (raycastHit.collider.CompareTag("Monster"))
				{
					Debug.Log("Monster clicked");
				}
			}

		}
	}

}

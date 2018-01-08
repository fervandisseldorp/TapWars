using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour {
	public int hp;
	public int speed;
	public int price;

	// Use this for initialization
	void Start() {
		
	}
	
	// Update is called once per frame
	void Update() {
		transform.Translate ( Vector3.right * Time.deltaTime * speed );
	}

	public int getPrice(){
		return price;
	}
}

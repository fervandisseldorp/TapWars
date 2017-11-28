using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour {
	public Rigidbody rigidbody;
	public int hp;
	public int speed;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
		rigidbody.velocity = transform.right * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

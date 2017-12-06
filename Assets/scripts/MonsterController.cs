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
        //transform.Translate(Vector3.right * speed, Space.Self);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void onMouseDown()
    {
        doDamage(10);
    }

    void doDamage(int damage)
    {
        Debug.Log("do damage method");
        hp -= damage;
        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}

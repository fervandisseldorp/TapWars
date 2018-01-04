using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour {
	public int hp;
	public int speed;

	// Use this for initialization
	void Start () {
<<<<<<< HEAD
		rigidbody = GetComponent<Rigidbody> ();
		rigidbody.velocity = transform.right * speed;
        //transform.Translate(Vector3.right * speed, Space.Self);
=======
>>>>>>> UiTestingBranch
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate ( Vector3.right * Time.deltaTime * speed );
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour {
	public int hp;
	public int speed;
	public int price;

	// Use this for initialization
	void Start() {
        // Let the monster face the right direction
        transform.Rotate(new Vector3(0, 90));
	}
	
	// Update is called once per frame
	void Update() {
        // Let the monster move forward on every frame
		transform.Translate ( Vector3.forward * Time.deltaTime * speed );
	}

	public int getPrice(){
		return price;
	}

    public void DamageMonster()
    {
        Debug.Log("Monster damaged. Had hp: " + hp);
        // If hp is still above 1, keep damaging it
        if(hp > 1)
        {
            hp -= 1;
        }
        else
        {
            // Destroy if it hits 0 hp
            Debug.Log("Monster is dead. removing game object");
            Destroy(gameObject);
        }
        

        Debug.Log("Monster new hp: " + hp);
    }
}

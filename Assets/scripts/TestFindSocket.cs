using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SocketIO;

public class TestFindSocket : MonoBehaviour {
	public GameObject monsterA;
    public GameObject monsterB;

    ArrayList monsterArray;

	public Vector3 spawn;
	SocketIOComponent socket;
	
	// Use this for initialization
	void Start () {
        monsterArray.Add("A");
        monsterArray.Add("B");


		GameObject socketObject = GameObject.Find("SocketIO");
		if(socketObject != null){
			Debug.Log ("found the object");

			socket = socketObject.GetComponent<SocketIOComponent>();
			if (socket != null) {
				Debug.Log ("found something named socket");
				socket.On("monsterSpawn", MonsterSpawn);

			}
		}
			
	}

	private void MonsterSpawn(SocketIOEvent evt){
		Debug.Log ("monster spawn called");

        string type = "";
        string level;
        

        if (evt.data != null)
        {
            Debug.Log("type monster wordt geprint: " + type);
            JSONObject monsterType = evt.data.GetField("monsterType");
            JSONObject monsterLevel = evt.data.GetField("monsterLevel");

            type = monsterType.n.ToString();

            if (type == "A")
            {
                //Instantiate(monster, spawn.position, spawn.rotation);

            }
        }

        Vector3 spawnPosition = new Vector3(spawn.x, spawn.y, Random.Range(-spawn.z, spawn.z));



        
    }


	public void MonsterButtonPressed(string type){
		Debug.Log ("Button was clicked from monster: " + type + " !");

        JSONObject obj = new JSONObject();
        obj.AddField("monsterType", type);
        obj.AddField("monsterLevel", 1);

        socket.Emit("monsterSpawn", obj);
        //Instantiate (monster, spawn.position, spawn.rotation);
    }

}

using UnityEngine;
using SocketIO;

public class TestFindSocket : MonoBehaviour {

	GameObject spawn;
	GameObject gameController;
	IncomeScript incomeScript;


	SocketIOComponent socket;
	
	// Use this for initialization
	void Start () {
		gameController = GameObject.Find ("GameController");
		incomeScript = gameController.GetComponent<IncomeScript>();
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

	// Server sends to opponent
	private void MonsterSpawn(SocketIOEvent evt){
		Debug.Log ("monster spawn called");

        string type = "";
        int level = 1;
        

        if (evt.data != null)
        {
            Debug.Log("type monster wordt geprint: " + type);
            JSONObject monsterType = evt.data.GetField("monsterType");
            JSONObject monsterLevel = evt.data.GetField("monsterLevel");

            type = monsterType.str.ToString();
            level = int.Parse(monsterLevel.n.ToString());
            Debug.Log("Received monster type: " + type + " of level: " + level);
            //Vector3 spawnPosition = new Vector3(spawn.x, spawn.y, Random.Range(-spawn.z, spawn.z));

            spawn = GameObject.Find("Spawn");
            Transform transform = spawn.GetComponent<Transform>();

            string monsterPath = "prefabs/Monster" + type;

            Debug.Log("Path test was: " + monsterPath);

            GameObject monster = (GameObject) Resources.Load(monsterPath) as GameObject;
            if(monster != null)
            {
                Debug.Log("Monster found");
            }
            else
            {
                Debug.Log("Monster not found");
            }

            Debug.Log("Spawn position was: " + transform.position + " and rotation: " + transform.rotation);
            Instantiate(monster, transform.position, transform.rotation);

            
        }
			
        
    }


	// Player sends this to server
	public void MonsterButtonPressed(string type){
		Debug.Log ("Button was clicked from monster: " + type + " !");

		string monsterPath = "prefabs/Monster" + type;
		GameObject monsterObj = (GameObject) Resources.Load(monsterPath) as GameObject;
		MonsterController monsterController = monsterObj.GetComponent<MonsterController> ();

		// Check if player has enough gold.
		if(incomeScript.getGold() >= monsterController.getPrice() ){
			Debug.Log("You have " + incomeScript.getGold() + " Gold and the monster costs " + monsterController.getPrice() );

			// adding income
			int increment = monsterController.getPrice () / 2;
			incomeScript.addIncome (increment);

			// paying for monster
			incomeScript.substractGold( monsterController.getPrice() );
			Debug.Log ("new gold value = " + incomeScript.getGold() + " new income value = " + incomeScript.getIncome() );

			// Create the json object and send monster
			JSONObject obj = new JSONObject();
			obj.AddField("monsterType", type);
			obj.AddField("monsterLevel", 1);

			socket.Emit("monsterSpawn", obj);

		}
			
    }
}

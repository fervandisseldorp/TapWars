using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SocketIO;
using UnityEngine.SceneManagement;

public class IncomeScript : MonoBehaviour {
	private float incomeTime = 20.0f;
	private bool won;
	bool canContinue = true;
	Scene scene;
	GameObject socketObject;
	SocketIOComponent socket;
	public int income;
	public int gold;
	public int lives;

	public Text timerText;
	public Text incomeText;
	public Text goldText;
	public Text livesText;


	// Use this for initialization
	void Start () {
//		income = 10;
//		gold = 50;
//		lives = 10;
		scene = SceneManager.GetActiveScene ();

		socketObject = GameObject.Find("SocketIO");
		socket = socketObject.GetComponent<SocketIOComponent>();
		socket.On("opponentLost", opponentLost);

		livesText.text = "Lives: " + lives;
		incomeText.text = "Income: " + income;
	}
	
	// Update is called once per frame
	void Update () {
		if(canContinue){
			timerText.text = "timer: " + incomeTime;

			incomeTime -= Time.deltaTime;
			if (incomeTime <= 0) {
				addIncomeGold (income);
				incomeTime = 10.0f;
			}
		}
	}

	// Add your income to your current gold
	void addIncomeGold(int inc){
			this.gold += inc;
			goldText.text = "Gold: "+ this.gold;
	}


	// Get your income value
	public int getIncome(){
		return income;
	}
		
	// Add a value to your income
	public void addIncome(int value){
		this.income +=value;
		incomeText.text = "Income: "+ this.income;
	}

	// Get your current gold value
	public int getGold(){
		return gold;
	}

	// Substract a value from your current gold.
	public void substractGold(int value){
		this.gold -= value;
		goldText.text = "Gold: "+ this.gold;
	}

	public int getLives(){
		return lives;
	}

	// Reduces players lives by 1
	public void substractLive(){
		this.lives -= 1;
		livesText.text = "Lives: " + this.lives;

		if(lives < 1){
			Debug.Log ("Lives reached 0");

			socket.Emit("lostAllLives");
			won = false;
			socket.socket.Close ();
			Destroy (socketObject);
			canContinue = false;
			Application.LoadLevel ("EndGameScreen");
		}
	}

	public bool getWon(){
		return this.won;
	}

	private void opponentLost(SocketIOEvent evt){
		won = true;
		socket.socket.Close ();
		Destroy (socketObject);
		canContinue = false;
		Application.LoadLevel ("EndGameScreen");
	}
		



}

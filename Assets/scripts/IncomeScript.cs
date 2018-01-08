using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncomeScript : MonoBehaviour {
	private float incomeTime = 20.0f;
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

		livesText.text = "Lives: " + lives;
		incomeText.text = "Income: " + income;
	}
	
	// Update is called once per frame
	void Update () {
		timerText.text = "timer: " + incomeTime;

		incomeTime -= Time.deltaTime;
		if (incomeTime <= 0) {
			addIncomeGold (income);
			incomeTime = 10.0f;
		}
	}

	// Add your income to your current gold
	void addIncomeGold(int inc){
		this.gold += inc;
		goldText.text = "Gold: "+ this.gold;
		//Debug.Log ("your current gold: " + gold);
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
}

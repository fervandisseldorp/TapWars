using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncomeScript : MonoBehaviour {
	private float incomeTime = 20.0f;
	private int income;
	private int gold;

	public Text timerText;
	public Text incomeText;
	public Text goldText;



	// Use this for initialization
	void Start () {
		income = 10;
		gold = 50;
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

	void addIncomeGold(int inc){
		gold += inc;
		Debug.Log ("your current gold: " + gold);
	}
}

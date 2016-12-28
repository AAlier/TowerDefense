using UnityEngine;
using System.Collections;

public class Currency : MonoBehaviour {
	public static int Money;
	public int startMoney = 400;
	public static int Lives;
	public int startLives = 20;
	public static int Rounds;

	void Start () {
		Money = startMoney;
		Lives = startLives;

		Rounds = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

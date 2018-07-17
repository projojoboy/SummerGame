using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerCurrency : MonoBehaviour {

    [SerializeField] private Text _MoneyText;

    [HideInInspector] public int playerMoneyAmount;

	public void AddMoney(int moneyToAdd)
    {
        playerMoneyAmount += moneyToAdd;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        _MoneyText.text = "$ " + playerMoneyAmount;
	}
}

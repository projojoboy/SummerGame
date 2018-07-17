using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMoney : MonoBehaviour {

    PlayerCurrency pc;
    [SerializeField] private int _MinMoney;
    [SerializeField] private int _MaxMoney;

    // Use this for initialization
    void Start () {
        pc = GameObject.Find("GameManager").GetComponent<PlayerCurrency>();
	}

    // Just call this Function to add the money
    public void AddMoneyToWallet()
    {
        int moneyToAdd = Random.Range(_MinMoney, _MaxMoney);
        pc.AddMoney(moneyToAdd);
    }
}

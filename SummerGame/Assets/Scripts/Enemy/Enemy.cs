using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy/Type")]
public class Enemy : ScriptableObject {

	[SerializeField]private string _name;
	[SerializeField]private string _challengeRating;

	[SerializeField]private Sprite _art;	

 	[SerializeField]private int _lvl;
	[SerializeField]private float _hp;
	[SerializeField]private float _mp;
	[SerializeField]private float _spd;
	[SerializeField]private float _baseDmg;

	[SerializeField]private bool _noMp;

	public void SetStats() {
		_hp = Mathf.Round(_hp * _lvl / 2 + 3);

		if(!this._noMp)
			_mp = Mathf.Round(_mp * _lvl / 2 + 10);
		else
			_mp = 0;

		Debug.Log("name: " + _name + " \r" +
		"lvl: " + _lvl + " \r" +
		"hp: " + _hp + " \r" +
		"mp: " + _mp + " \r" +
		"spd: " + _spd + " \r" +
		"dmg: " + _baseDmg);
	}
}

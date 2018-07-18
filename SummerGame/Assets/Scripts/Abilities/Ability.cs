using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ability", menuName = "Ability/New")]
public class Ability : ScriptableObject {

	[Header("\tSpell Information")]
	[SerializeField]private string _name;
	[SerializeField, Tooltip("e.g physical, fire, nature, death, water, ice")]private string _type;
	[SerializeField]private string _desc;

	[SerializeField]private GameObject _spellPrefab;

	[SerializeField]private float _mCost;
	[SerializeField]private float _spellDmg;

//---------------------------------//
//---- AREA OF EFFECT SETTINGS ----//
//---------------------------------//		
	[Header("\tAOE Settings")]
	[SerializeField, Tooltip("Area Of Effect")]private bool _isAOE;
	[SerializeField]private float _aoeDmg;

//-----------------------------------//
//---- DAMAGE OVER TIME SETTINGS ----//
//-----------------------------------//	
	[Header("\tDOT Settings")]
	[SerializeField, Tooltip("Damage Over Time")]private bool _isDOT;
	[SerializeField, Range(1,4)]private int _dotDur;
	[SerializeField]private float _dotDmg;

//------------------------------------//
//---- HEALING OVER TIME SETTINGS ----//
//------------------------------------//
	[Header("\tHOT Settings")]
	[SerializeField, Tooltip("Healing Over Time")]private bool _isHOT;
	[SerializeField, Range(1,4)]private int _hotDur;
	[SerializeField]private float _hotAmount;


	public void GetAbility() {
		_aoeDmg = Mathf.Round(_spellDmg / 3);
		_dotDmg = Mathf.Round(_spellDmg / 4);
		_hotAmount = Mathf.Round(_spellDmg / 3);

		Debug.Log("name: " + _name +
		" type: " + _type +
		" description: " + _desc +
		" cost: " + _mCost +
		" dmg: " + _spellDmg +
		" AOE: " + _isAOE +
		" AOEdmg: " + _aoeDmg +
		" DOT: " + _isDOT +
		" DOTdur: " + _dotDur +
		" DOTdmg: " + _dotDmg +
		" HOT: " + _isHOT + 
		" HOTdur: " + _hotDur +
		" HOTamount: " + _hotAmount);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityType : MonoBehaviour {

	[SerializeField]private Ability _ability0;
	[SerializeField]private Ability _ability1;
	[SerializeField]private Ability _ability2;
	[SerializeField]private Ability _ability3;

	private void Start() {
		_ability0.GetAbility();
		_ability1.GetAbility();
		_ability2.GetAbility();
		_ability3.GetAbility();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType : MonoBehaviour {

	[SerializeField]private Enemy _enemy;

	private void Start() {
		_enemy.SetStats();
	}
}

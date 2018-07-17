using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Console : MonoBehaviour {

	private string _textInput;

	[SerializeField]private GameObject _cInput;

	private void Start() {
		_cInput.SetActive(false);
	}

	void Update(){
		if (Input.GetKeyDown(KeyCode.C))
			OpenConsole();
	}

	public void OpenConsole(){
		if (_cInput.activeSelf)
			_cInput.SetActive(false);
		else
			_cInput.SetActive(true);
		Debug.Log("opened");
	}
}

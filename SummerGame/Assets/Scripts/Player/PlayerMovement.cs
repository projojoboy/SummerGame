using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [SerializeField] private float _MovementSpeedHor = 10;
    [SerializeField] private float _MovementSpeedVer = 5;

    private Rigidbody2D rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Movement();
	}

    void Movement()
    {
        var v = Input.GetAxis("Vertical");
        var h = Input.GetAxis("Horizontal");

        rb.velocity = new Vector3(h * Time.deltaTime * _MovementSpeedHor, v * Time.deltaTime * _MovementSpeedVer);
    }
}

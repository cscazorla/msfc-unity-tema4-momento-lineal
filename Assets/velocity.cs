using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velocity : MonoBehaviour {

	private Rigidbody rb; 
	public Vector3 velocidadInicial = new Vector3(0,0,0);

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.velocity = velocidadInicial;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Velocity of " + transform.name + ": " + rb.velocity);
	}
}

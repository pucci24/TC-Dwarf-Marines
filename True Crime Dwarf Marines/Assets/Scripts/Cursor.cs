using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour {

	//public GameObject Cursor;
	public Vector3 mousePos;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		mousePos = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0.3f));
		this.transform.position = mousePos;
	}
}
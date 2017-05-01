using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objecto : MonoBehaviour {

	public bool hover = false;
	public bool click = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		click=Input.GetMouseButtonDown(0);
		if (hover==true&&click==true){
			Debug.Log("clicked");
		}
	}

	void OnTriggerStay2D(Collider2D other){
		hover=true;
	}
	void OnTriggerExit2D(Collider2D other){
		hover=false;
	}
}
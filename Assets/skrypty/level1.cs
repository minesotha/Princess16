using UnityEngine;
using System.Collections;

public class level1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

	void OnTriggerEnter2D(Collider2D coll){
		if  (coll.gameObject.tag == "Player") {
			Application.LoadLevel (1);
		}
		
	}
	}


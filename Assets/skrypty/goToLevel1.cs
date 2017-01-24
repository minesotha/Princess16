using UnityEngine;
using System.Collections;

public class goToLevel1 : MonoBehaviour {

//ładowanie pierwszego poziomu po dotknieciu mety

	void OnTriggerEnter2D(Collider2D coll){
		if  (coll.gameObject.tag == "Player") {
			Application.LoadLevel (1);
		}
		
	}
	}


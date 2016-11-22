using UnityEngine;
using System.Collections;

public class DestroyEnemy : MonoBehaviour {

		// Use this for initialization
	void Start () {
		
	}


	
	// Update is called once per frame
	
void OnTriggerEnter2D(Collider2D coll){
				if  (coll.gameObject.tag == "Enemy") {
			GetComponent<AudioSource>().Play();
			Destroy (coll.gameObject);
					Destroy (gameObject);
		}

	}
	
}


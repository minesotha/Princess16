using UnityEngine;
using System.Collections;

public class DestroyEnemy : MonoBehaviour {

void OnTriggerEnter2D(Collider2D coll){
				if  (coll.gameObject.tag == "Enemy") {
			GetComponent<AudioSource>().Play();
			Destroy (coll.gameObject);
					Destroy (gameObject); //usuwanie przeciwników z planszy
		}

	}
	
}


using UnityEngine;
using System.Collections;

public class bulletCleaner : MonoBehaviour {


	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "pocisk" ){
						Destroy (coll.gameObject); // usuwanie z planszy pocisków, które w nic nie trafiły
				}
		
}
}
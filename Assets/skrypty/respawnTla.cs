using UnityEngine;
using System.Collections;

public class respawnTla : MonoBehaviour {

void OnTriggerEnter2D(Collider2D collider){
		Vector3 pos = collider.transform.position;


		if (Application.loadedLevelName == "tutorial"||Application.loadedLevelName == "level_las") {
			pos.x += 48f; // przesuwanie grafiki z tłem o daną jednostkę w zależności od planszy
				} else 
			pos.x += 27f; // przesuwanie grafiki z tłem o daną jednostkę w zależności od planszy
		collider.transform.position = pos;

		}
}


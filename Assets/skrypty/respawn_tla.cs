using UnityEngine;
using System.Collections;

public class respawn_tla : MonoBehaviour {

void OnTriggerEnter2D(Collider2D collider){
		Vector3 pos = collider.transform.position;


		if (Application.loadedLevelName == "tutorial"||Application.loadedLevelName == "level_las") {
						pos.x += 48f;
				} else 
						pos.x += 27f;
		collider.transform.position = pos;

		}
}


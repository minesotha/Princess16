using UnityEngine;
using System.Collections;

public class playTutorial : MonoBehaviour {

	
	// obsługa ładowania tutoriala
	void Update () {
		if (Input.GetKey (KeyCode.Space) || Input.GetMouseButton (0) || (Input.touchCount == 1)) {
			Application.LoadLevel (2); // ładowanie tutorialu
				}
	}
}

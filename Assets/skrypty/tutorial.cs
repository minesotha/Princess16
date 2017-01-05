using UnityEngine;
using System.Collections;

public class tutorial : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space) || Input.GetMouseButton (0) || (Input.touchCount == 1)) {
			Application.LoadLevel (2); // ładowanie tutorialu
				}
	}
}

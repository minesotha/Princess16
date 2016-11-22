using UnityEngine;
using System.Collections;

public class obrotMonety : MonoBehaviour {

	public Vector3 obrot;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate( obrot * Time.deltaTime);
	}
}

using UnityEngine;
using System.Collections;

public class Grawitacja : MonoBehaviour {

	Vector3 ped = Vector3.zero;
	public Vector3 grawit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		ped += grawit;
		transform.position = ped * Time.deltaTime;

	}
}

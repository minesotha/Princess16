using UnityEngine;
using System.Collections;

public class gravitation : MonoBehaviour {

    //grawitacja skoków
	Vector3 ped = Vector3.zero;
	public Vector3 grawit;


	void Update () {
		ped += grawit;
		transform.position = ped * Time.deltaTime;

	}
}

using UnityEngine;
using System.Collections;

public class cameraGravitation : MonoBehaviour {
	public float wysokoscPlanszy=3;

	void Start () {
	
	}	

	void Update () {
		Vector3 poz = transform.position;
		if (poz.y > wysokoscPlanszy) {		
		transform.position += Vector3.down*10*Time.deltaTime;		//odbijanie kamery w dół	 
			}

	}
}

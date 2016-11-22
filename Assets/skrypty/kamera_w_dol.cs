using UnityEngine;
using System.Collections;

public class kamera_w_dol : MonoBehaviour {
	public float wysokoscPlanszy=3;

	void Start () {
	
	}	

	void Update () {
		Vector3 poz = transform.position;
		if (poz.y > wysokoscPlanszy) {		
		transform.position += Vector3.down*10*Time.deltaTime;			 
			}

	}
}

using UnityEngine;
using System.Collections;

public class moveBackground : MonoBehaviour {
		public float tlo;

    //kamera porusza się jednostajnie
	void RuchKamery(){
		
		Vector3 wektor = new Vector3 (tlo*Time.deltaTime, 0, 0);
		transform.Translate (wektor);
		
	}


	void FixedUpdate () {
        RuchKamery ();
		
	}
}

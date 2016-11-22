using UnityEngine;
using System.Collections;

public class kamera : MonoBehaviour {

	public Transform ksiezniczka;
	
	void RuchKamery(){
				
			Vector3 wektor = new Vector3 (2*Time.deltaTime, 0, 0);
			transform.Translate (wektor);

	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {RuchKamery ();
	
	}
}

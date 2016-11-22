using UnityEngine;
using System.Collections;

public class ruchTla : MonoBehaviour {
	
	public Transform ksiezniczka;
	public float tlo;

	void RuchKamery(){
		
		Vector3 wektor = new Vector3 (tlo*Time.deltaTime, 0, 0);
		transform.Translate (wektor);
		
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {RuchKamery ();
		
	}
}

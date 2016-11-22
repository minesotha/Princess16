using UnityEngine;
using System.Collections;

public class tloSieNieRusza : MonoBehaviour {

	float posY;
	
	void Awake ()
	{
		posY = transform.position.y;

	}
	
		
		void FixedUpdate ()
	{
		//All your other stuff
		transform.position = new Vector3(transform.position.x, posY, transform.position.z); //For the Z value, if it isn't 0, you can set it to the transform.position.z, or just store another variable if you want.
	}
}
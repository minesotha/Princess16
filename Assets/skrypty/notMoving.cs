using UnityEngine;
using System.Collections;

public class notMoving : MonoBehaviour {

	float posY;
	
	void Awake ()
	{
		posY = transform.position.y;

	}
	
		
		void FixedUpdate ()
	{
        //upewniamy sie, ze jest zawsze w tym samym miesjcu
		transform.position = new Vector3(transform.position.x, posY, transform.position.z); 
	}
}
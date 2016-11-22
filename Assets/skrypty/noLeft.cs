using UnityEngine;
using System.Collections;

public class noLeft : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


	float xPos;
	
	void  FixedUpdate ()
	{
		xPos = transform.position.x;
	}
		
		void Update()
	{
				if (transform.position.x < xPos)
						transform.position = new Vector3 (xPos, transform.position.y, 0);
		}
}

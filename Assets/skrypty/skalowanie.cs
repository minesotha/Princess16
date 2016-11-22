using UnityEngine;
using System.Collections;

public class skalowanie : MonoBehaviour {

	// 
	public Texture tekstura;


	void OnGUI()
	{
		// 
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), tekstura, ScaleMode.ScaleToFit, true);
	}



	void Update()
	{
				if ((Input.GetKey (KeyCode.RightArrow) || Input.GetMouseButton (1) || (Input.touchCount == 1 && Input.GetTouch (0).position.x > (Screen.height / 2)) || (Input.GetKey (KeyCode.LeftArrow) || Input.GetMouseButton (0) || (Input.touchCount == 1 && Input.GetTouch (0).position.x <= (Screen.height / 2)))))
						{

						}
				
		}


}

using UnityEngine;
using System.Collections;

public class bieg2 : MonoBehaviour {

	float ped;
	public int wysokoscSkoku;
	bool skok=false;
	int grawit;

	//void OnTriggerEnter(Collider other)
	//{
	//	Debug.Log ("platforma");
	//
	//}

	void Skok()
	{if (Input.GetKeyDown (KeyCode.Space)) {
			skok = true;	
			transform.Translate (0, wysokoscSkoku * Time.deltaTime,0);

		}
		if(skok == true){
			skok = false;
				}

		}
		

	void Bieg() //w sumie na razie nie uzywane, bo podpiete do ruchu kamery
	{
				
				transform.Translate (ped,0,0);
		}

	// Use this for initialization
	void Start () {ped = ped*Time.deltaTime;
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Bieg ();
		Skok ();
	}
}

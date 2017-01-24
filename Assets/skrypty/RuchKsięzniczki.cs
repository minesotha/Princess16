using UnityEngine;
using System.Collections;

public class RuchKsięzniczki : MonoBehaviour {

	float ped;
	public int wysokoscSkoku;
	int grawit;



	void Skok()
	{
        while (Input.GetKeyDown(KeyCode.Space)) {
			transform.Translate (0, wysokoscSkoku * Time.deltaTime,0);

		}

	}
		

	void Bieg()
	{
        transform.Translate (ped,0,0);
    }


	void Start () {
        //początkowy pęd
        ped = ped*Time.deltaTime;
	}
	
	void FixedUpdate () {
		Bieg ();
		Skok ();
	}
}

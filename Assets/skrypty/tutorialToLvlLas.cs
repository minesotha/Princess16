using UnityEngine;
using System.Collections;

public class tutorialToLvlLas : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Application.LoadLevel(4); // przejście do poziomu 1
        }
    }
    }

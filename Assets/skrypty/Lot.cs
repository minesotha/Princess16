using UnityEngine;
using System.Collections;

public class Lot : MonoBehaviour {
	
	public float time = 0;

	void EnemyMov2(){
		GetComponent<Rigidbody2D>().velocity = new Vector2 (5, 0);
	}

		
	// Use this for initialization
	void Start () {		
	}
	
	// Update is called once per frame
	void Update () {
		EnemyMov2();
		time += Time.deltaTime;
		if (time > 1.5) 
		{
			this.GetComponent<AudioSource>().Play ();
			Destroy (gameObject);

		}
	}
}
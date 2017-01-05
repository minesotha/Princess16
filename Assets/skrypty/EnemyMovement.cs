using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public float time = 0;
	public float czas_rozn = 2.5f;
	bool obrot = false;

	
	void EnemyMov(){
		GetComponent<Rigidbody2D>().velocity = new Vector2 (-1, 0);
	}
	void EnemyMov2(){
		GetComponent<Rigidbody2D>().velocity = new Vector2 (1, 0);
		}

	void enemyTurning(){
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}


	// Use this for initialization
	void Start () {
		enemyTurning ();

	}
	
	// Update is called once per frame
	void Update () {
		EnemyMov ();
		time += Time.deltaTime;

		if (time >= czas_rozn) {
			if(obrot == false){
				enemyTurning ();
				obrot = true;
			}

		}
		else{
			EnemyMov2 ();
		}
		if (time >= (czas_rozn + 3.0f)) {
			time = 0;
			enemyTurning ();
			obrot = false;
				}

	}
}

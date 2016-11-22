using UnityEngine;
using System.Collections;

public class princessMovement : MonoBehaviour {
	
	Vector3 predkosc = Vector3.zero;
	public GameObject Fireball;
	public Vector3 predkoscSkoku;
	public Vector3 hasanie;
	public float maxPredkosc = 5f;
	public GameObject AUhopsa;
	public GameObject AUfireball;
	private bool czyPodloga=true;
	public int maxIloscPociskow=1;

	
	//bool skok = false;
	
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			        if (Input.GetKeyDown (KeyCode.Escape)) { //zeby dalo sie wyjsc normalnie z gry
			          Application.LoadLevel(0); 
				}
	}
	
	void FixedUpdate(){
        //ruch postaci
        Vector3 wektor = new Vector3(2 * Time.deltaTime, 0, 0);
        transform.Translate(wektor);

        if (czyPodloga == true) {	
						if (Input.GetKey (KeyCode.RightArrow) || Input.GetMouseButton (1) || (Input.touchCount == 1 && Input.GetTouch (0).position.x > (Screen.height / 2))) {
								//AUhopsa.audio.Play ();
								predkosc += predkoscSkoku;
	
								predkosc = Vector3.ClampMagnitude (predkosc, maxPredkosc);
								transform.position += predkosc * Time.deltaTime;
						}
				
						else if (Input.GetKey (KeyCode.LeftArrow) || Input.GetMouseButton (0) || (Input.touchCount == 1 && Input.GetTouch (0).position.x <= (Screen.height / 2))) {
								//miotanie fireballi
								if (GameObject.FindGameObjectsWithTag ("pocisk").Length < maxIloscPociskow) {

										Pocisk ();
								}
						}
				}
		}

	// Ustawic hasanie na 1, zeby hasała//

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Podloga") {
						predkosc = hasanie;
				} else if (coll.gameObject.tag != "Podloga") {
						czyPodloga = true;
				}
	}

	void OnCollisionExit(Collision coll){
				if (coll.gameObject.name == "Podloga") {
						czyPodloga = false;
				}
		}
	void Pocisk() {
		Instantiate (Fireball, transform.position, transform.rotation);
		AUfireball.GetComponent<AudioSource>().Play ();
		Debug.Log ("FIRE FIRE!");
	}
}

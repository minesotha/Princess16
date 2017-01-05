using UnityEngine;
using System.Collections;

public class s : MonoBehaviour {
	
	public int kasa = 0;
	public int zycia=3;
	public string monety;
	public GameObject AUmonety, AUprzeciwnik, AUprzegrana;
	public GUITexture monetaGUI;
	public GUITexture bol1, bol2, bol3,gameover;
	public float szybkoscGry=0.5f;
	
	// Use this for initialization
	void Start () {
		Time.timeScale=szybkoscGry;
		monety="0";
		bol1.enabled = false;
		bol2.enabled = false;
		bol3.enabled = false;
		gameover.enabled = false;
	}

	
	void OnGUI () {
		GUI.Box (new Rect (Screen.width - 25,5,20,20),monety);
		GUI.Box (new Rect (Screen.width - 25,25,20,20), zycia.ToString()); //wyświetlanie liczników w odpowiednim położeniu ekranu
	}

	void OnCollisionStay(Collision dotyk){
		if (dotyk.gameObject.tag == "Trap")
						zycia--; //odejmowanie punktów życia po wpadnięciu na pułapkę
		}


	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Coin") {
			AUmonety.GetComponent<AudioSource>().Play ();
			Destroy (coll.gameObject);
			kasa += 1;
			monety = kasa.ToString (); //zbieranie monet
				}
		else if (coll.gameObject.tag == "Skrzynia") {
			AUmonety.GetComponent<AudioSource>().Play ();
			Destroy (coll.gameObject);
			kasa += 10;
			monety = kasa.ToString ();  //zbieranie skrzyń z monetami
		}

		else if (coll.gameObject.tag == "Enemy"||coll.gameObject.tag=="Trap"||coll.gameObject.tag=="Heart") {
			switch (coll.gameObject.tag)
			{
			case "Enemy":
				Destroy(coll.gameObject);
				AUprzeciwnik.GetComponent<AudioSource>().Play();
				zycia--; //odejmowanie punktów życia po wpadnięciu na przeciwnika
				break;
			case "Trap":
				AUprzeciwnik.GetComponent<AudioSource>().Play();
				coll.gameObject.GetComponent<Collider2D>().enabled=false;
				zycia--;  //odejmowanie punktów życia po wpadnięciu na pułapkę
				break;
			case "Heart":
				AUmonety.GetComponent<AudioSource>().Play ();
				Destroy (coll.gameObject);
				zycia++;  //zbieranie punktów życia
				break;
			
			}
			if (zycia>0){
				switch (zycia) // wyświetlanie się nakładki z teksturą krwi w zależności od liczby punktów życia
				{
				case 1:
					bol1.enabled=false;
					bol3.enabled=true;
					bol2.enabled=false;
					break;
				case 2:
					bol2.enabled=true;
					bol1.enabled=false;
					bol3.enabled = false;
					break;
				case 3:
					bol1.enabled=true;
					bol2.enabled = false;
					bol3.enabled = false;
					break;
				case 4:
					bol1.enabled = false;
					bol2.enabled = false;
					bol3.enabled = false;
					break;
				case 5:
					bol1.enabled = false;
					bol2.enabled = false;
					bol3.enabled = false;
					break;
				}
			}

		

			else if (zycia<=0){
				gameover.enabled=true; //wyświetlanie ekranu "game over"
				bol3.enabled=false;
				Time.timeScale=0.0f;
				AUprzegrana.GetComponent<AudioSource>().Play();
				//Destroy (this.gameObject);
				Destroy(monetaGUI);
		
			}
				
		}
			else if (coll.gameObject.tag=="Koniec_Ekranu"){
		//	transform.position = new Vector3(transform.position.x+0.5f, transform.position.y, transform.position.z);
			//lub w razie jakbyśmy nie chcieli, by się teleportował
			Application.LoadLevel("menu"); 
			}
	}
}
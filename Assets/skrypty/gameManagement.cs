using UnityEngine;
using System.Collections;

public class gameManagement : MonoBehaviour {
	
    //zarządzanie gui, znajdzkami, zyciem
	public int kasa = 0;
	public int zycia=3;
	public string monety;
	public GameObject AUmonety, AUprzeciwnik, AUprzegrana;
	public GUITexture monetaGUI;
	public GUITexture bol1, bol2, bol3,gameover;
	public float szybkoscGry=0.5f;
	

	void Start () {
		Time.timeScale=szybkoscGry;
		monety="0";
        //dostępne pociski
		bol1.enabled = false;
		bol2.enabled = false;
		bol3.enabled = false;
		gameover.enabled = false;
	}

	
	void OnGUI () {
		GUI.Box (new Rect (Screen.width - 25,5,20,20),monety);
		GUI.Box (new Rect (Screen.width - 25,25,20,20), zycia.ToString());
	}

	void OnCollisionStay(Collision dotyk){
		if (dotyk.gameObject.tag == "Trap")
						zycia--;
		}


	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Coin") {
			AUmonety.GetComponent<AudioSource>().Play ();
			Destroy (coll.gameObject);
			kasa += 1;
			monety = kasa.ToString ();
				}
		else if (coll.gameObject.tag == "Skrzynia") {
			AUmonety.GetComponent<AudioSource>().Play ();
			Destroy (coll.gameObject);
			kasa += 10;
			monety = kasa.ToString ();
		}

		else if (coll.gameObject.tag == "Enemy"||coll.gameObject.tag=="Trap"||coll.gameObject.tag=="Heart") {
			switch (coll.gameObject.tag)
			{
			case "Enemy":
				Destroy(coll.gameObject);
				AUprzeciwnik.GetComponent<AudioSource>().Play();
				zycia--;
				break;
			case "Trap":
				AUprzeciwnik.GetComponent<AudioSource>().Play();
				coll.gameObject.GetComponent<Collider2D>().enabled=false;
				zycia--;
				break;
			case "Heart":
				AUmonety.GetComponent<AudioSource>().Play ();
				Destroy (coll.gameObject);
				zycia++;
				break;
			
			}
			if (zycia>0){
				switch (zycia)
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
				gameover.enabled=true;
				bol3.enabled=false;
				Time.timeScale=0.0f;
				AUprzegrana.GetComponent<AudioSource>().Play();
				//Destroy (this.gameObject);
				Destroy(monetaGUI);
		
			}
				
		}
        //obłsuga za szybkiej lub spóźnionej księżniczki
			else if (coll.gameObject.tag=="Koniec_Ekranu"){
		//	transform.position = new Vector3(transform.position.x+0.5f, transform.position.y, transform.position.z);
			//lub w razie jakbyśmy nie chcieli, by się teleportował
			Application.LoadLevel("menu"); 
			}
	}
}
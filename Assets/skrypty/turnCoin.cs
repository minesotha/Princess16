using UnityEngine;
using System.Collections;

public class turnCoin : MonoBehaviour {

	public Vector3 obrot;

	void Update () {
		transform.Rotate( obrot * Time.deltaTime);
	}
}

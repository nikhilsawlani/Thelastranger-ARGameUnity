using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour {
	public GameObject bloodyscreen;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void zombieAttack(bool Zombieispresent){
		bloodyscreen.gameObject.SetActive (true);
		StartCoroutine (waittwoseconds ());

	}

	IEnumerator waittwoseconds(){
		yield return new WaitForSeconds (2f);
		bloodyscreen.gameObject.SetActive (false);
	}
}

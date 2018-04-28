using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollsionwithEnemy : MonoBehaviour {


	public bool zombieispresent;
	float timer;
	int timebetweenattack;
	AudioSource attacksound;
	private GameControllerScript gameController;
	// Use this for initialization
	void Start () {
		timebetweenattack = 2;
		GameObject gamecontrollerobject = GameObject.FindWithTag ("GC");

		if (gamecontrollerobject != null) {
			gameController = gamecontrollerobject.GetComponent<GameControllerScript> ();
		}

		AudioSource[] audios = GetComponents<AudioSource> ();
		attacksound = audios [0];
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;


		if (zombieispresent && timer >= timebetweenattack) {
			Attack ();
		}
	}

	void OnCollisionEnter (Collision col){
		//Debug.Log ("Enter");
		if((col.gameObject.tag == "MainCamera")){

			Debug.Log ("Enter");
			zombieispresent = true;

		}
	}



	void OnCollisionExit (Collision col){

		if((col.gameObject.tag == "MainCamera")){

			Debug.Log ("Exit");
			zombieispresent = false;
		}
	}


	public void Attack(){
		timer = 0f;
		GetComponent<Animator> ().Play ("attack");
		gameController.zombieAttack (zombieispresent);
		attacksound.Play ();
	}


}



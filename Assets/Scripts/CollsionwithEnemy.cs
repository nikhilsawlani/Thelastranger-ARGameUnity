using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollsionwithEnemy : MonoBehaviour {


	public bool zombieispresent;
	float timer;
	int timebetweenattack;
	// Use this for initialization
	void Start () {
		
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
		timer = 0;
		GetComponent<Animator> ().Play ("attack");
	}
}



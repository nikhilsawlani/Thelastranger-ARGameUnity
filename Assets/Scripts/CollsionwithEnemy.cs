using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollsionwithEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col){
		Debug.Log ("Enter");
		if((col.gameObject.tag == "MainCamera")){

			Debug.Log ("Enter");
		}
	}



	void OnCollisionExit (Collision col){

		if((col.gameObject.tag == "MainCamera")){

			Debug.Log ("Exit");
		}
	}


	void Attack(){

	}
}

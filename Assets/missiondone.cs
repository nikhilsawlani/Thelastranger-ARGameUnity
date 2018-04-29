using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class missiondone : MonoBehaviour {


	public GameObject its;
	public bool gotenergy = false;
	public Text mission;
  	// Use this for initialization
	void Start () {
		mission.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 0, Time.deltaTime * 15);

		if (gotenergy) {
			IncEn ();
		}
	}

	void OnCollisionEnter (Collision col){
		//Debug.Log ("Enter");
		if((col.gameObject.tag == "MainCamera")){

			Debug.Log ("Enterenergy");
			gotenergy = true;

		}
	}



	void OnCollisionExit (Collision col){

		if((col.gameObject.tag == "MainCamera")){

			Debug.Log ("Exitenergy");
			gotenergy = false;
		}
	}

	void IncEn(){

		//encount += 5;
		//resl.text = encount.ToString ();
		//energysound.Play ();
		Destroy (its, .2f);
		mission.gameObject.SetActive (true);
	}
}

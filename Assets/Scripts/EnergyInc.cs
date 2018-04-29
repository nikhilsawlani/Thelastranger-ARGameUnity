using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyInc : MonoBehaviour {


	public Text resl;
	public int encount = 0;
	public bool gotenergy = false;
	public AudioSource energysound;
	public GameObject itself;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
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

		encount += 5;
		resl.text = encount.ToString ();
		energysound.Play ();
		Destroy (itself, .2f);
	}
}

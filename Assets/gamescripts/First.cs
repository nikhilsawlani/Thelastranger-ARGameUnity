using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First : MonoBehaviour {
	 
	public GameObject mainui;

	// Use this for initialization
	void Start () {
		mainui.SetActive (false);
	}
	
	public void Activeani(){
		mainui.SetActive (true);
	}
}

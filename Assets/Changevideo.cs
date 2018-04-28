using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changevideo : MonoBehaviour {
	public GameObject video1;
	public GameObject video2;
	public GameObject video3;
	public GameObject video4;
	// Use this for initialization
	void Start () {
		video1.SetActive (false);
		video2.SetActive (false);
		video3.SetActive (false);
		video4.SetActive (false);
	}
	
	// Update is called once per frame
	public void play1(){
		video1.SetActive (true);
		video2.SetActive (false);
		video3.SetActive (false);
		video4.SetActive (false);

	}

			public void play2(){
		video1.SetActive (false);
		video2.SetActive (true);
		video3.SetActive (false);
		video4.SetActive (false);

	}

	public void play3(){
		video1.SetActive (false);
		video2.SetActive (false);
		video3.SetActive (true);
		video4.SetActive (false);

	}

	public void play4(){
		video1.SetActive (false);
		video2.SetActive (false);
		video3.SetActive (false);
		video4.SetActive (true);

	}
}

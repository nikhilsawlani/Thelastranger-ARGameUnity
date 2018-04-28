using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwapnController : MonoBehaviour {


	public GameObject zombie;
	public Button startgame;
	// Use this for initialization
	void Start () {
		startgame.onClick.AddListener (startInvoke);
	}
	// Update is called once per frame
	void Update () {
		
	}


	void startInvoke(){

		InvokeRepeating ("spawn", 0f, 5f);

	}

	void spawn(){
		Vector3 position = new Vector3 (Random.Range(-10f,10f),Random.Range(-3f,3f),Random.Range(-10f,10f));
		Instantiate (zombie,position,Quaternion.Euler(0,0,0));
	}
}

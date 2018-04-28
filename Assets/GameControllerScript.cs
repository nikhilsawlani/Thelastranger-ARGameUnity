using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour {
	public GameObject bloodyscreen;
	public Text healthtext;
	public Button startgame;
	public int health;

	// Use this for initialization
	void Start () {
		health = 100;
	}
	
	// Update is called once per frame
	void Update () {
		if(health <= 0){

			SceneManager.LoadScene (3);

		}
	}

	public void zombieAttack(bool Zombieispresent){
		bloodyscreen.gameObject.SetActive (true);
		StartCoroutine (waittwoseconds ());
		health -= 4;
		string stringhealth = (health).ToString();
		healthtext.text = " " + stringhealth;
	}

	IEnumerator waittwoseconds(){
		yield return new WaitForSeconds (2f);
		bloodyscreen.gameObject.SetActive (false);
	}
}

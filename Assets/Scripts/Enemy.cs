﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

	public float health = 30f;
	public int result =0;
	public Text res;
	AudioSource bloodsound;
	// Use this for initialization
	void Start () {
		AudioSource[] audios = GetComponents<AudioSource> ();
		bloodsound = audios [1];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TakeDamage(float damage)
	{

		bloodsound.Play ();
		health -= damage;
		print (health);

		if (health <= 0f) 
		{
			Die ();
		}
	}

	void Die()
	{
		result += 1;
		Destroy (gameObject, 1f);
		res.text = result.ToString ();

	}
}

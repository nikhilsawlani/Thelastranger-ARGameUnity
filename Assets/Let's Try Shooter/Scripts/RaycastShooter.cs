using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShooter : MonoBehaviour {

	public int gundamage = 1;
	public float firerate = .25f;
	public float weaponrange = 50f;
	public float hitforce = 100f;
	public Transform gunend;


	private  Camera fpscam;
	private WaitForSeconds shotduration = new WaitForSeconds(.7f);

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shootEnemy : MonoBehaviour {

	public Button shootBtn;
	public Camera fpsCam;
	public float damage = 10f;
	public GameObject blood;


	// Use this for initialization
	void Start () {

		shootBtn.onClick.AddListener (onShoot);

	}
	
	void onShoot()
	{
		RaycastHit hit;
		if (Physics.Raycast (fpsCam.transform.position, fpsCam.transform.forward, out hit)) 
		{

			Enemy target = hit.transform.GetComponent<Enemy> ();

			if (target != null) 
			{
				target.TakeDamage (damage);
				Instantiate(blood,hit.point,Quaternion.LookRotation(hit.normal));
				Destroy (blood, .2f);
			}

			// drestroy enemy
			// instantiate blood effect
			// load shooting effect 
			//Debug.Log (hit.transform.name);
		}
	}
}

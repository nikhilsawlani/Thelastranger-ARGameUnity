using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shootEnemy : MonoBehaviour {

	public Button shootBtn;
	public Camera fpsCam;
	public float damage = 10f;
	public GameObject blood;
	public GameObject shteft;
	public int forceadd = 300;
	AudioSource shoot;
	AudioSource reload;
	public ParticleSystem muzzleflash;

	public Text res;
	Enemy en;
	public GameObject pisgo;
	// Use this for initialization
	void Start () {
		en = new Enemy ();
		shootBtn.onClick.AddListener (onShoot);
		AudioSource[] audios = GetComponents<AudioSource> ();
		shoot = audios [0];
		reload = audios [1];
	}
	
	void onShoot()
	{
		res.text = en.result.ToString ();
		shoot.Play ();
		RaycastHit hit;
		if (Physics.Raycast (fpsCam.transform.position, fpsCam.transform.forward, out hit)) 
		{

			Enemy target = hit.transform.GetComponent<Enemy> ();

			if (target != null) {
				target.TakeDamage (damage);
				GameObject  bloodgo  =	Instantiate (blood, hit.point, Quaternion.LookRotation (hit.normal));
				Destroy (bloodgo, .2f);

			}
				else{
				GameObject  shtgo  =Instantiate(shteft,hit.point,Quaternion.LookRotation(hit.normal));
				Destroy (shtgo, .2f);
				reload.Play ();
				}

			if (hit.rigidbody != null) {
				Debug.Log ("back");
				hit.rigidbody.AddForce (-hit.normal * forceadd);
			}
			muzzleflash.Play ();
			}
		muzzleflash.Play ();


		pisgo.GetComponent<Animator> ().Play("Fire");
			// drestroy enemy
			// instantiate blood effect
			// load shooting effect 
			//Debug.Log (hit.transform.name);
		}
	}


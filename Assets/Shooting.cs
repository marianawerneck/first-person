using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	public float damage = 10.0f;
	public float range = 100.0f;

	public AudioSource gunShotAudioSource;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("Shoot");
			Shoot ();
		}
		
	}

	void Shoot()
	{
		RaycastHit hit;

		gunShotAudioSource.PlayOneShot(gunShotAudioSource.clip);

		if (Physics.Raycast (transform.position, transform.forward, out hit)) {
			Debug.Log (hit.transform.name);
			Target target = hit.transform.GetComponent<Target> ();
			if (target != null) {
				target.TakeDamage ();
			}

		}


	}
}

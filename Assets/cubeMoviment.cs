using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMoviment : MonoBehaviour {

	public int speed;
	public int height;
	bool up = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < 0.5) {
			up = true;
		} else {
			if (transform.position.y > height) {
				up = false;
			}
		}
		if (up) {
			transform.Translate (new Vector3 (0, speed * Time.deltaTime, 0));
		} else {
			transform.Translate (new Vector3 (0, (-1) * speed * Time.deltaTime, 0));
		}

		
	}
}

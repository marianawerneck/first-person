using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour {

	public GameObject cam;
	public GameObject img;

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.GetComponent<Target> () != null) {
			Debug.Log (GetComponent<UnityEngine.Collider>().gameObject.name);
			transform.Rotate (90.0f, 0, 0);
			GameObject newCam = Instantiate (cam,new Vector3(cam.transform.position.x,cam.transform.position.y,cam.transform.position.z),new Quaternion());
			newCam.GetComponent<Camera> ().enabled = true;
			Destroy (this.gameObject);
			Destroy (img);

		}
	}
}

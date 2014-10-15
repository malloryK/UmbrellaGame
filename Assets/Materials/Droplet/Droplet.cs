using UnityEngine;
using System.Collections;

public class Droplet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!this.renderer.isVisible) {
			Destroy(this.gameObject);
		}
	}
//
//	void OnCollisionEnter2D(Collision2D collision) {
//		
//
//		if (collision.gameObject.CompareTag ("Teeter")&& this.gameObject.CompareTag("Droplet")) {
//
//			this.rigidbody2D.mass  = collision.gameObject.rigidbody2D.mass*.2f;
//			this.gameObject.tag = "LightDroplet";
//		}
//		
//	}

}

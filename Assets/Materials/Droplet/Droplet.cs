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

	void OnCollisionEnter2D(Collision2D collision) {
		
		Debug.Log (collision.gameObject.CompareTag ("Teeter"));
		Debug.Log (this.gameObject.CompareTag("Droplet"));
		if (collision.gameObject.CompareTag ("Teeter")&& this.gameObject.CompareTag("Droplet")) {
			Debug.LogError("teeter");
			this.rigidbody2D.mass  = collision.gameObject.rigidbody2D.mass*.2f;
			this.gameObject.tag = "LightDroplet";
		}
		
	}

}

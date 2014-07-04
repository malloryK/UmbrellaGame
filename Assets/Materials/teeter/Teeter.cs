using UnityEngine;
using System.Collections;

public class Teeter : MonoBehaviour {



	void OnCollisionEnter2D(Collision2D collision) {


		if (collision.gameObject.CompareTag ("Droplet")) {
			collision.gameObject.rigidbody2D.mass  = collision.gameObject.rigidbody2D.mass/2;
			collision.gameObject.tag = "LightDroplet";
		}
		
	}
}

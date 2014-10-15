using UnityEngine;
using System.Collections;

public class Droplet : MonoBehaviour {

	public int drops;

	// Use this for initialization
	void Start () {
		drops = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (!this.renderer.isVisible) {
			Destroy(this.gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D collision) {

		if (collision.gameObject.CompareTag ("Teeter")) {
			drops++;
		}
		
	}

}

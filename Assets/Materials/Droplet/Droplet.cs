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
		if (this.rigidbody2D.velocity.y < 0) {
			GetComponent<Animator> ().SetBool ("falling",true) ;
		} else {
			GetComponent<Animator> ().SetBool ("falling",false);
		}
	}

	void OnCollisionEnter2D(Collision2D collision) {

		if (collision.gameObject.CompareTag ("Teeter")) {
			drops++;
			this.transform.GetChild(0).GetComponent<TextMesh>().text = drops.ToString();
			Animator anim = this.GetComponent<Animator>();
			anim.SetTrigger("hit");

		}
		
	}

}

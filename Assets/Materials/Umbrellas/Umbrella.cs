using UnityEngine;
using System.Collections;

public class Umbrella : MonoBehaviour {

	public int Height { get;set;}
	public bool MovingRight { get; set; }

	public bool Hit { get; set; }

	public float Speed { get; set; }
	public bool hasBeenSeen = false;
	public Sprite burst;
	public GameObject splash;

	//int smooth = 2;

	// Use this for initialization
	void Start () {
		this.Hit = false;

		StartCoroutine(moveUmbrella ());
	}

	void FixedUpdate(){
	//wait for umbrella to go on screen and off again, then destroy
		if (!Hit) {
			if (!hasBeenSeen) {
					if (this.renderer.isVisible) {

							hasBeenSeen = true;
					}
			} else if (hasBeenSeen && this.renderer.isVisible == false) {

					Destroy (this.gameObject.gameObject);
			}
		}
	}

	IEnumerator moveUmbrella (){
		
		while(!Hit )
		{
			if(this.MovingRight == true){
				this.transform.Translate(Vector3.right * this.Speed * Time.deltaTime);

			}
			else{
				this.transform.Translate(Vector3.left * this.Speed * Time.deltaTime);

			}
			yield return null;
		}
		//yield return null;
	}

	
	void OnCollisionEnter2D(Collision2D collision) {
		
		
		if (collision.gameObject.CompareTag ("Droplet") || collision.gameObject.CompareTag ("LightDroplet") ) {
			Destroy (this.GetComponent<Collider2D>());
			this.Hit = true;
			this.GetComponent<Animator>().SetBool("floating", false);
			GameObject ps = (GameObject)Instantiate(splash, transform.position, Quaternion.identity);
			ps.renderer.sortingLayerName = "GameElements";
			SpriteRenderer render = this.gameObject.GetComponent<SpriteRenderer>();
			render.sprite= this.burst;
			render.sortingOrder =-1;
			Destroy(collision.gameObject);
			Destroy (this.gameObject, 1);

		}
	}
}

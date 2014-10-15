using UnityEngine;
using System.Collections;

public class SpawnDrops : MonoBehaviour {
	public GameObject droplet;
	public GameObject dropCount;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GameObject count = (GameObject)Instantiate(dropCount, Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z)), Quaternion.identity);
			GameObject drop = (GameObject)Instantiate(droplet, Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z)), Quaternion.identity);
			count.gameObject.transform.parent = drop.gameObject.transform;
		}

	}
}

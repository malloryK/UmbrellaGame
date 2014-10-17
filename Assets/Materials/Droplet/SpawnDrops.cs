using UnityEngine;
using System.Collections;

public class SpawnDrops : MonoBehaviour {
	public GameObject droplet;
	public GameObject dropCount;
	private Rect spawnArea;
	private float spawnWidth = Screen.width;
	private float spawnHeight = (float)(Screen.height*0.2);
	// Use this for initialization
	void Start () {
		spawnArea = new Rect(0,Screen.height-spawnHeight,spawnWidth,Screen.height);

		LineRenderer line=this.GetComponent<LineRenderer>();
		line.SetVertexCount(2); 
		line.SetColors (Color.black, Color.black);
		line.SetPosition(0, Camera.main.ScreenToWorldPoint(new Vector3(0,Screen.height-spawnHeight,-Camera.main.transform.position.z))); 
		line.SetPosition(1, Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height-spawnHeight,-Camera.main.transform.position.z))); 
		line.SetWidth(0.2f,0.2f);
	

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			if(spawnArea.Contains(Input.mousePosition)){
				Vector3 point = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
				GameObject count = (GameObject)Instantiate(dropCount, point, Quaternion.identity);
				GameObject drop = (GameObject)Instantiate(droplet,point, Quaternion.identity);
				count.gameObject.transform.parent = drop.gameObject.transform;
			}

		}

	}
}

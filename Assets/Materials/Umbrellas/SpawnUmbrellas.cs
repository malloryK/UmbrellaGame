using UnityEngine;
using System.Collections;

public class SpawnUmbrellas : MonoBehaviour {

	public Transform [] spawnPoints = new Transform[4];
	public Umbrella [] umbrellas = new Umbrella[4];



	// Use this for initialization
	void Start () {
		StartCoroutine (placeUmbrellas ());
	}
	
	// Update is called once per frame
	void Update () {



	}

	IEnumerator placeUmbrellas(){

		while (true) {
			//choose random spawn point and place random umbrella there			
			float temp1 = Random.Range (0, spawnPoints.Length);
			Transform spawn = spawnPoints [(int)temp1];
			Umbrella umbrella = (Umbrella)Instantiate (umbrellas [Random.Range (0, spawnPoints.Length)], spawn.transform.position, spawn.transform.rotation);

			//set speed to random value and first half of spawn points goto the righ second half to the left
			umbrella.Speed = Random.Range (3f, 7);
			if (temp1 > ((spawnPoints.Length/2)+1)){
					umbrella.MovingRight = false;
			}else{
					umbrella.MovingRight = true;
			}

			yield return new WaitForSeconds(2);
			}

	}



}

	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour {

	public GameObject fruitPrefab2;
	public Transform[] spawnPoints;

	public float minDelay=.1f;
	public float maxDelay=10f;

	void Start () {
        StartCoroutine(SpawnFruits());
	}
	IEnumerator SpawnFruits()
	{
		while (true) 
		{
			float delay = Random.Range (minDelay, maxDelay);
			yield return new WaitForSeconds (1f);

			int spawnındex = Random.Range (0, spawnPoints.Length);
			Transform spawnPoint = spawnPoints [spawnındex];

			GameObject spawnedFruit2 = Instantiate (fruitPrefab2, spawnPoint.position, spawnPoint.rotation);
			
			Destroy(spawnedFruit2, 2.1f);
			
		}
	}
}
 
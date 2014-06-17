using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
	
	public float spawnMin = 5f;
	public float spawnMax = 10f;
	public float objectScaleMin = 1f;
	public float objectScaleMax = 1f;
	public GameObject[] objectToSpawn;		// Array of enemy prefabs.
	
	void Start ()
	{
		Spawn ();
	}
	
	void Spawn ()
	{
		// Instantiate a random enemy.
		int index = Random.Range(0, objectToSpawn.Length);
		Vector3 pos = Camera.main.ViewportToWorldPoint (new Vector3(Random.value, 1, 0));
		Vector3 SpawnPosition = transform.position;
		SpawnPosition.x = pos.x;
		GameObject SpawnedObject = (GameObject)Instantiate(objectToSpawn[index], SpawnPosition, transform.rotation);
		float scale = Random.Range(objectScaleMin, objectScaleMax);
		SpawnedObject.transform.localScale = new Vector3 (scale, scale, 1);

		Invoke ("Spawn", Random.Range(spawnMin, spawnMax));
	}
}
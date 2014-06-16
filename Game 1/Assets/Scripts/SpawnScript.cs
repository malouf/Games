using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
	
	public float spawnTime = 5f;		// The amount of time between each spawn.
	public float spawnDelay = 3f;		// The amount of time before spawning starts.
	public float objectScaleMin = 1f;
	public float objectScaleMax = 1f;
	public GameObject[] objectToSpawn;		// Array of enemy prefabs.
	
	void Start ()
	{
		// Start calling the Spawn function repeatedly after a delay .
		InvokeRepeating("Spawn", spawnDelay, spawnTime);
	}
	
	void Spawn ()
	{
		// Instantiate a random enemy.
		int index = Random.Range(0, objectToSpawn.Length);
		GameObject SpawnedObject = (GameObject)Instantiate(objectToSpawn[index], transform.position, transform.rotation);
		float scale = Random.Range(objectScaleMin, objectScaleMax);
		SpawnedObject.transform.localScale = new Vector3 (scale, scale, 1);
	}
}
using UnityEngine;
using System.Collections;

public class PlanetScript : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}

	void RevealBonus()
	{
		//Debug.Break ();
		return;
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.collider.tag == "Player")
			RevealBonus ();
	}

	// Update is called once per frame
	void Update () {
		Vector3 movedPosition = transform.position;
		movedPosition.y += DrillerScript.GlobalSpeed * (Time.timeSinceLevelLoad / 300);
		transform.position = movedPosition;
	}
}

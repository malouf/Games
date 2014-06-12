using UnityEngine;
using System.Collections;

public class DrillerController : MonoBehaviour {

	private Animator animator;
	private bool IsDrilling = false;
	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		var vertical = Input.GetAxis("Vertical");
		if (vertical < 0)
			IsDrilling = true;			
		else
			IsDrilling = false;
		
		animator.SetBool ("IsDrilling", IsDrilling);
	}
}

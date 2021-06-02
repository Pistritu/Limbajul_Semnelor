using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apasare_Buton : MonoBehaviour {

	private Animator _animator = null;
	public bool apasat = false;

	// Use this for initialization
	void Start () {
		_animator = GetComponent<Animator> ();
	}
	
	void Update () {

		if (Input.GetButtonDown("Jump"))
			_animator.SetBool ("apasat", true);
		if (Input.GetButtonUp("Jump"))
			_animator.SetBool ("apasat", false);
	}



	public void OnCollisionEnter(Collision collision)
	{
		_animator.SetBool ("apasat", true);
		//Check for a match with the specified name on any GameObject that collides with your GameObject
		if (collision.gameObject.name == "Mana");
		{
			//If the GameObject's name matches the one you suggest, output this message in the console
			Debug.Log ("Do something here");
			_animator.SetBool ("apasat", true);
		}
	}

	public void OnTriggerExit(Collider collider) {

		_animator.SetBool ("apasat", false);
		Debug.Log ("iesit");
	}
}

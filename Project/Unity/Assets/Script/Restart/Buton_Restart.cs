using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buton_Restart : MonoBehaviour {


	void Update() {
		if (Input.GetKey(KeyCode.R))
			SceneManager.LoadScene ("Scena");

		if (Input.GetKey(KeyCode.E))
			Application.Quit ();
	}


	public void restartGame(){

		SceneManager.LoadScene ("Scena");
		
		//Application.LoadLevel ("Scena");
	}

	public void exitGame(){
		
		Application.Quit ();
}

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect_Zona1 : MonoBehaviour
{
	
	public bool xxx = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	

	
	
	
	void OnTriggerEnter (Collider other){
		
		if (gameObject.tag == "zona1" ) {
			xxx = false;
		}
	}
	
	void OnTriggerExit(Collider other){

		if (gameObject.tag == "zona1" ) {
			xxx = true;
			Debug.Log ("A IESIT degetul mare");
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRotation : MonoBehaviour
{
	//	public GameObject playerRadacina;       //Public variable to store a reference to the player game object
	//	private Vector3 newRotation;
		
		
	//	public GameObject player;       //Public variable to store a reference to the player game object
		//private Vector3 offset;         //Private variable to store the offset distance between the player and camera
		//private Vector3 offset2;         //Private variable to store the offset distance between the player and camera
		
		public Transform c;
		public float roltatie;
		
		public Transform Dmare;
		public float Dmare_roltatie;
		
		public Transform Daratator;
		public float Daratator_roltatie;
		


    // Start is called before the first frame update
    void Start()
    {
		 //Calculate and store the offset value by getting the distance between the player's position and camera's position.
   //    offset = transform.position - player.transform.position;
	
    }

    // Update is called once per frame
    void Update()
    {
      // print(c.transform.localRotation.eulerAngles.x);  
	  var angles = c.transform.localRotation.eulerAngles;
	  roltatie = angles.x;
	  
	  var angles_Dmare = Dmare.transform.localRotation.eulerAngles.z;
	  
	  int x2 = System.Convert.ToInt32(angles_Dmare);
	  Dmare_roltatie = x2;
	  
	  var angles_Daratator = Daratator.transform.localRotation.eulerAngles.z;
	  int x1 = System.Convert.ToInt32(angles_Daratator);
	  Daratator_roltatie = x1;


	  
//	  Vector3 newRotation = new Vector3(playerRadacina.transform.localRotation.eulerAngles.x, playerRadacina.transform.localRotation.eulerAngles.y, playerRadacina.transform.localRotation.eulerAngles.z);
//	  this.transform.eulerAngles = newRotation;
    }
	
	    void LateUpdate () 
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
 //       transform.position = player.transform.position - offset;

    }
}

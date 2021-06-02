using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class EnterZona1 : MonoBehaviour {
		
	public float timer = 0.0f;
	public float timp_difuzare = 2.0f;
	private int counter = 0;
	
	AudioSource playerAudio;
	
	public AudioClip _ana;  
	public AudioClip _are;  
	public AudioClip _mere;  
	public AudioClip _salut;
	public AudioClip _mancare;
	public AudioClip _apa;
	   

	public GameObject img_ana;	 
	public GameObject img_are;
	public GameObject img_mere;
	public GameObject img_salut;
	public GameObject img_mancare;
	public GameObject img_apa;
	 
		
	public bool mare = false;
	public bool aratator = false;
	public bool mijlociu= false;
	public bool inelar = false;
	public bool mic = false;

    void Awake () {
	playerAudio = GetComponent <AudioSource> ();
    }
	
	 void Start() {

    }
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if(mare == true && aratator == true && mijlociu == true && inelar == true && mic == true){
			timer = 0;
			counter = 0;
			
			img_salut.SetActive(false);
			img_ana.SetActive(false);
			img_are.SetActive(false);
			img_mere.SetActive(false);
			img_mancare.SetActive(false);
			img_apa.SetActive(false);			
		}
		
		if(mare == false && aratator == false && mijlociu == false && inelar == false && mic == false){

			if(timer > timp_difuzare){
				counter++;
				if(counter == 1){
				Debug.Log ("Au trecut 2 secunde! fa ceva");
				img_salut.SetActive(true);
				img_ana.SetActive(false);
				img_are.SetActive(false);
				img_mere.SetActive(false);
				img_mancare.SetActive(false);
				img_apa.SetActive(false);
				
				
				playerAudio.clip = _salut;
				playerAudio.Play ();
				
			}
			}
		}

		
	}
	
	
	
	void OnTriggerEnter(Collider other){

		if(other.gameObject.tag == "mare"){
			mare = true;	
			timer = 0;
			sunet_Imagine();
		}
		if(other.gameObject.tag == "aratator"){
			aratator = true;
			timer = 0;
			sunet_Imagine();
		}
		if(other.gameObject.tag == "mijlociu"){
			mijlociu = true;
			timer = 0;			
			sunet_Imagine();
		}
		if(other.gameObject.tag == "inelar"){
			inelar = true;
			timer = 0;
			sunet_Imagine();
		}
		if(other.gameObject.tag == "mic"){
			mic = true;
			timer = 0;
			sunet_Imagine();
		}
		Debug.Log ("A intrat un deget in Zona1");
	}

	void OnTriggerExit(Collider other){

		if(other.gameObject.tag == "mare"){
			mare = false;
			timer = 0;
			sunet_Imagine();
			
		}
		if(other.gameObject.tag == "aratator"){
			aratator = false;
			timer = 0;
			sunet_Imagine();	
		}
		if(other.gameObject.tag == "mijlociu"){
			mijlociu = false;
			timer = 0;
			sunet_Imagine();
		}
		if(other.gameObject.tag == "inelar"){
			inelar = false;
			timer = 0;
			sunet_Imagine();
		}
		if(other.gameObject.tag == "mic"){
			mic = false;
			timer = 0;
			sunet_Imagine();
		}
		Debug.Log ("A IESIT un deget din Zona1");
	}
	
	
	
	public void sunet_Imagine() {
Debug.Log ("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
		if(mare == false && aratator == false && mijlociu == false && inelar == false && mic == false){

			if(timer > 2.0f){
				Debug.Log ("Au trecut 2 secunde! fa ceva");
				img_salut.SetActive(true);
				
				img_ana.SetActive(false);
				img_are.SetActive(false);
				img_mere.SetActive(false);
				img_mancare.SetActive(false);
				img_apa.SetActive(false);
				
				
				playerAudio.clip = _salut;
				playerAudio.Play ();
				
			}
		}
		
		if(mare == true && aratator == true && mijlociu == false && inelar == false && mic == true){

			if(timer > 2.0f){
				Debug.Log ("Au trecut 2 secunde! fa ceva");
				
				img_salut.SetActive(false);
				img_ana.SetActive(false);
				img_are.SetActive(false);
				img_mere.SetActive(false);
				img_mancare.SetActive(true);
				img_apa.SetActive(false);
				
				
				playerAudio.clip = _mancare;
				playerAudio.Play ();
				
			}
		}

		if(mare == false && aratator == true && mijlociu == true && inelar == false && mic == false){

			if(timer > 2.0f){
				Debug.Log ("Au trecut 2 secunde! fa ceva");
				
				img_salut.SetActive(false);
				img_ana.SetActive(false);
				img_are.SetActive(false);
				img_mere.SetActive(false);
				img_mancare.SetActive(false);
				img_apa.SetActive(true);
				
				
				playerAudio.clip = _apa;
				playerAudio.Play ();
				
			}
		}		
		
	}
}

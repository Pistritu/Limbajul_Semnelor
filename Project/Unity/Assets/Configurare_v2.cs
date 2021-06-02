using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Configurare_v2 : MonoBehaviour
{
	// variabile pentru a salva gradul de rotatie al degetelor si al mainii
	public Transform Mana;
	public Transform Deget0;
	public Transform Deget1;
	public Transform Deget2;
	public Transform Deget3;
	public Transform Deget4;
	public float R_Mana_X;
	public float R_Mana_Y;
	public float R_Mana_Z;
	public float R_Deget0;
	public float R_Deget1;
	public float R_Deget2;
	public float R_Deget3;
	public float R_Deget4;
	
	public int Pozitie_Mana = 0;
	
	
	
	// variabile pentru a vedea pozitia degetelor:     0 = deget intins  /  1 = deget strans
	public bool mare = false;
	public bool aratator = false;
	public bool mijlociu= false;
	public bool inelar = false;
	public bool mic = false;
	public bool TEST = false;

	
	// preluare sunete pentru imagini
	AudioSource playerAudio;
	public AudioClip _cheama;  
	public AudioClip _politia;  
	public AudioClip _pompierii;  
	public AudioClip _salut;
	public AudioClip _mancare;
	public AudioClip _apa;
	public AudioClip _1;	
	public AudioClip _2;
	public AudioClip _3;
	public AudioClip _4;
	public AudioClip _5;
	public AudioClip _nu;
	public AudioClip _da;
	public AudioClip _vaMultumesc;
	public AudioClip _vinoCuMine;
	public AudioClip _nevoieMedic;
	public AudioClip _nevoieAjutor;
	public AudioClip _maSimtBine;
	public AudioClip _euRoxana;
	public AudioClip _catCosta;

	public GameObject img_cheama;	 
	public GameObject img_politia;
	public GameObject img_pompierii;
	public GameObject img_salut;
	public GameObject img_mancare;
	public GameObject img_apa;
	public GameObject img_1;
	public GameObject img_2;
	public GameObject img_3;
	public GameObject img_4;
	public GameObject img_5;
	public GameObject img_nu;
	public GameObject img_da;
	public GameObject img_vaMultumesc;
	public GameObject img_vinoCuMine;
	public GameObject img_nevoieMedic;
	public GameObject img_nevoieAjutor;
	public GameObject img_maSimtBine;
	public GameObject img_euRoxana;
	public GameObject img_catCosta;

	
	//contorizare trecerea timpului
	public float timp_difuzare = 2.0f;
	public float timer = 0.0f;
	private int counter = 0;
	
	private int action_on_frame = 0;
	
	
	void Awake () {
		playerAudio = GetComponent <AudioSource> ();
    }
	
    // Start is called before the first frame update
    void Start()
    {
        
    }
	
	// Reseteaza tot la 0
	void Reset()
	{
		
		if(mare == false && aratator == false && mijlociu == false && inelar == false && mic == false && TEST == false){
			timer = 0;
			counter = 0;
			
			disable_all();

		} // set 0
		
		if(mare == true && aratator == true && mijlociu == true && inelar == true && mic == true && TEST == false){
			timer = 0;
			counter = 0;
			
			disable_all();
			
		} // set 0
	}
	
	
	
	
	void disable_all()
	{
		
		img_salut.SetActive(false);
		img_cheama.SetActive(false);
		img_politia.SetActive(false);
		img_pompierii.SetActive(false);
		img_mancare.SetActive(false);
		img_apa.SetActive(false);	

		img_1.SetActive(true);
		img_2.SetActive(false);
		img_3.SetActive(false);
		img_4.SetActive(false);
		img_5.SetActive(false);
		img_nu.SetActive(false);
		img_da.SetActive(false);
			
		img_vaMultumesc.SetActive(false);
		img_vinoCuMine.SetActive(false);
		img_nevoieMedic.SetActive(false);
		img_nevoieAjutor.SetActive(false);
		img_maSimtBine.SetActive(false);
		img_euRoxana.SetActive(false);
		img_catCosta.SetActive(false);		
	} // end disable_all()
	
	// Actualizeaza pozitia Mainii si a degetelor
	void getPosition()
	{
		
		var angles_X = Mana.transform.localRotation.eulerAngles.x;
		int buff_X = System.Convert.ToInt32(angles_X);
		R_Mana_X = buff_X;
		
		var angles_Y = Mana.transform.localRotation.eulerAngles.y;
		int buff_Y = System.Convert.ToInt32(angles_Y);
		R_Mana_Y = buff_Y;
			
		var angles_Z = Mana.transform.localRotation.eulerAngles.z;
		int buff_Z = System.Convert.ToInt32(angles_Z);
		R_Mana_Z = buff_Z;
		
		var angles0 = Deget0.transform.localRotation.eulerAngles.z;
		int buff0 = System.Convert.ToInt32(angles0);
		R_Deget0 = buff0;
		
		var angles1 = Deget1.transform.localRotation.eulerAngles.z;
		int buff1 = System.Convert.ToInt32(angles1);
		R_Deget1 = buff1;
		
		var angles2 = Deget2.transform.localRotation.eulerAngles.z;
		int buff2 = System.Convert.ToInt32(angles2);
		R_Deget2 = buff2;
		
		var angles3 = Deget3.transform.localRotation.eulerAngles.z;
		int buff3 = System.Convert.ToInt32(angles3);
		R_Deget3 = buff3;
		
		var angles4 = Deget4.transform.localRotation.eulerAngles.z;
		int buff4 = System.Convert.ToInt32(angles4);
		R_Deget4 = buff4;
		
	} // end getPosition()
	
	
	// Seteaza pozitia mainii    poz 1,2,3
	void setPosition_mana()
	{
		
		if( ((R_Mana_X <= 40) &&  (R_Mana_X > -180)) &&  ((R_Mana_Z <= 90) && (R_Mana_Z >= -90)) ){  //mana intinsa normal dar cu palma in jos
			
			Pozitie_Mana = 1;
			
		}
		
		if( ((R_Mana_X <= 40) &&  (R_Mana_X > -180)) &&  ((R_Mana_Z > 91) && (R_Mana_Z < 91)) ){ //mana intinsa normal dar cu palma in sus
			
			Pozitie_Mana = 2;
			
		}	

		if(R_Mana_X > 41){  //mana este ridicata
			
			Pozitie_Mana = 3;
			
		}
		
	} // end setPosition_mana()
	
	
	
	void setPosition_deget()
	{
		if((R_Deget0 <= 340) && (R_Deget0 >= 200)){
			mare = true;
		}
		else{
			mare = false;
		}
		
		if((R_Deget1 <= 340) && (R_Deget1 >= 200)){
			aratator = true;
		}
		else{
			aratator = false;
		}
		
		if((R_Deget2 <= 340) && (R_Deget2 >= 200)){
			mijlociu= true;
		}
		else{
			mijlociu = false;
		}
		
		if((R_Deget3 <= 340) && (R_Deget3 >= 200)){
			inelar = true;
		}
		else{
			inelar = false;
		}
		
		if((R_Deget4 <= 340) && (R_Deget4 >= 200)){
			mic = true;
		}
		else{
			mic = false;
		}
		
	} // end setPosition_deget()
	
	
	void start_action()
	{
		
		// Variante de pozitie a degetelor
		if(mare == false && aratator == false && mijlociu == true && inelar == true && mic == true && Pozitie_Mana == 1){

			if(timer > timp_difuzare){
				++counter;
				if(counter == 1){
					Debug.Log ("Semn: Saluta");
			
					disable_all();
					img_salut.SetActive(true);
				
					playerAudio.clip = _salut;
					playerAudio.Play ();	
				}				
			}	
		} // end salut
		
		if(mare == false && aratator == false && mijlociu == false && inelar == true && mic == true && Pozitie_Mana == 1){

			if(timer > timp_difuzare){
				counter++;
				if(counter == 1){
					Debug.Log ("Semn: Mancare");
			
					disable_all();
					img_mancare.SetActive(true);
				
					playerAudio.clip = _mancare;
					playerAudio.Play ();			
				}
			}
		} //end mancare
		
		if(mare == true && aratator == false && mijlociu == false && inelar == true && mic == true && Pozitie_Mana == 1){

			if(timer > timp_difuzare){
				counter++;
				if(counter == 1){
					Debug.Log ("Semn: apa");
			
					disable_all();
					img_apa.SetActive(true);	
				
					playerAudio.clip = _apa;
					playerAudio.Play ();			
				}
			}
		} //end apa
		
		if(mare == false && aratator == true && mijlociu == true && inelar == true && mic == true && Pozitie_Mana == 1){

			if(timer > timp_difuzare){
				counter++;
				if(counter == 1){
					Debug.Log ("Semn: cheama");
			
					disable_all();
					img_cheama.SetActive(true);
				
					playerAudio.clip = _cheama;
					playerAudio.Play ();			
				}
			}
		} //end cheama
		
		if(mare == true && aratator == false && mijlociu == true && inelar == true && mic == true && Pozitie_Mana == 1){

			if(timer > timp_difuzare){
				counter++;
				if(counter == 1){
					Debug.Log ("Semn: politia");
			
					disable_all();
					img_politia.SetActive(true);
				
					playerAudio.clip = _politia;
					playerAudio.Play ();			
				}
			}
		} //end politia
		
		if(mare == true && aratator == true && mijlociu == true && inelar == true && mic == false && Pozitie_Mana == 1){

			if(timer > timp_difuzare){
				counter++;
				if(counter == 1){
					Debug.Log ("Semn:  pompierii");
			
					disable_all();
					img_pompierii.SetActive(true);
				
					playerAudio.clip = _pompierii;
					playerAudio.Play ();			
				}
			}
		} //end pompierii
		
		if(mare == true && aratator == false && mijlociu == true && inelar == true && mic == true && Pozitie_Mana == 3){

			if(timer > timp_difuzare){
				counter++;
				if(counter == 1){
					Debug.Log ("Semn: 1");

					disable_all();
					img_1.SetActive(true);

					playerAudio.clip = _1;
					playerAudio.Play ();			
				}
			}
		} //end 1

		if(mare == true && aratator == false && mijlociu == false && inelar == true && mic == true && Pozitie_Mana == 3){

			if(timer > timp_difuzare){
				counter++;
				if(counter == 1){
					Debug.Log ("Semn: 2");
			
					disable_all();
					img_2.SetActive(true);
				
					playerAudio.clip = _2;
					playerAudio.Play ();			
				}
			}
		} //end 2		
		
		if(mare == true && aratator == false && mijlociu == false && inelar == false && mic == true && Pozitie_Mana == 3){

			if(timer > timp_difuzare){
				counter++;
				if(counter == 1){
					Debug.Log ("Semn: 3");

					disable_all();
					img_3.SetActive(true);
				
					playerAudio.clip = _3;
					playerAudio.Play ();			
				}
			}
		} //end 3		
		
		if(mare == true && aratator == false && mijlociu == false && inelar == false && mic == false && Pozitie_Mana == 3){

			if(timer > timp_difuzare){
				counter++;
				if(counter == 1){
					Debug.Log ("Semn: 4");
			
					disable_all();
					img_4.SetActive(true);

				
					playerAudio.clip = _4;
					playerAudio.Play ();			
				}
			}
		} //end 4		
		
		if(mare == false && aratator == true && mijlociu == true && inelar == true && mic == true && Pozitie_Mana == 3){

			if(timer > timp_difuzare){
				counter++;
				if(counter == 1){
					Debug.Log ("Semn: 5");
			
					disable_all();
					img_5.SetActive(true);
				
					playerAudio.clip = _5;
					playerAudio.Play ();			
				}
			}
		} //end 5

		if(mare == false && aratator == true && mijlociu == true && inelar == true && mic == false && Pozitie_Mana == 1){

			if(timer > timp_difuzare){
				counter++;
				if(counter == 1){
					Debug.Log ("Semn: nu");
			
					disable_all();
					img_nu.SetActive(true);
				
					playerAudio.clip = _nu;
					playerAudio.Play ();			
				}
			}
		} //end NU

		if(mare == true && aratator == false && mijlociu == false && inelar == false && mic == true && Pozitie_Mana == 1){

			if(timer > timp_difuzare){
				counter++;
				if(counter == 1){
					Debug.Log ("Semn: da");
			
					disable_all();
					img_da.SetActive(true);
	
					playerAudio.clip = _da;
					playerAudio.Play ();			
				}
			}
		} //end DA

		if(mare == false && aratator == false && mijlociu == true && inelar == true && mic == false && Pozitie_Mana == 3){

			if(timer > timp_difuzare){
				counter++;
				if(counter == 1){
					Debug.Log ("Semn: Va multumesc");
				
					disable_all();
					img_vaMultumesc.SetActive(true);

					playerAudio.clip = _vaMultumesc;
					playerAudio.Play ();			
				}
			}
		} //end va multumesc

		if(mare == false && aratator == false && mijlociu == true && inelar == true && mic == true && Pozitie_Mana == 2){

			if(timer > timp_difuzare){
				counter++;
				if(counter == 1){
					Debug.Log ("Semn: nevoie medic");
			
					disable_all();
					img_nevoieMedic.SetActive(true);

				
					playerAudio.clip = _nevoieMedic;
					playerAudio.Play ();			
				}
			}
		} //end am nevoie de medic (palma in sus)

		if(mare == false && aratator == false && mijlociu == false && inelar == true && mic == true && Pozitie_Mana == 2){

			if(timer > timp_difuzare){
				counter++;
				if(counter == 1){
					Debug.Log ("Semn: nevoie ajutor");
	
					disable_all();
					img_nevoieAjutor.SetActive(true);

					playerAudio.clip = _nevoieAjutor;
					playerAudio.Play ();			
				}
			}
		} //end am nevoie de ajutor (palma in sus)
		
		if(mare == true && aratator == false && mijlociu == false && inelar == false && mic == false && Pozitie_Mana == 2){

			if(timer > timp_difuzare){
				counter++;
				if(counter == 1){
					Debug.Log ("Semn: ma simt bine");
			
					disable_all();
					img_maSimtBine.SetActive(true);

					playerAudio.clip = _maSimtBine;
					playerAudio.Play ();			
				}
			}
		} //end ma simt bine (palma in sus)
		
		if(mare == false && aratator == true && mijlociu == true && inelar == true && mic == true && Pozitie_Mana == 2){

			if(timer > timp_difuzare){
				counter++;
				if(counter == 1){
					Debug.Log ("Semn: eu Roxana");
			
					disable_all();
					img_euRoxana.SetActive(true);

					playerAudio.clip = _euRoxana;
					playerAudio.Play ();			
				}
			}
		} //end eu sunt roxana (palma in sus)
		
		if(mare == false && aratator == true && mijlociu == true && inelar == true && mic == false && Pozitie_Mana == 2){

			if(timer > timp_difuzare){
				counter++;
				if(counter == 1){
					Debug.Log ("Semn: vino cu mine");
					
					disable_all();
					img_vinoCuMine.SetActive(true);
		
					playerAudio.clip = _vinoCuMine;
					playerAudio.Play ();			
				}
			}
		} //end vino cu mine (palma in sus)
		
		if(mare == true && aratator == true && mijlociu == true && inelar == true && mic == false && Pozitie_Mana == 2){

			if(timer > timp_difuzare){
				counter++;
				if(counter == 1){
					Debug.Log ("Semn:  cat costa?");
			
					disable_all();
					img_catCosta.SetActive(true);
				
					playerAudio.clip = _catCosta;
					playerAudio.Play ();			
				}
			}
		} //end cat costa? (palma in sus)

	Debug.Log (TEST);	
		if(TEST == true){

			if(timer > timp_difuzare){
				counter++;
				if(counter == 1){
					Debug.Log ("Semn:  Test img si sunet");
			
					disable_all();
					img_1.SetActive(true);

					playerAudio.clip = _1;
					playerAudio.Play ();			
				}
			}
		} //TEST
	} //end start_action()




    // Update is called once per frame
    void Update()
    {
		timer += Time.deltaTime;
		action_on_frame++;
		
		if (action_on_frame == 3 ) //dupa 3 frame-uri sa se actualizeze datele)
		{			
			getPosition();
			setPosition_mana();
			setPosition_deget();
			Reset();
			start_action();
			action_on_frame = 0;
		}
    }  //end update

} //end main

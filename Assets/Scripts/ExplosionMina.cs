using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionMina : MonoBehaviour {

	public GameObject Sangre, Explosion;
	public GameObject gameOver;
	private GameObject ExplosionClone;
	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter2D (Collider2D ballena) {
		
		if (ballena.tag.Equals("ballena")) {
			//destriur mina
			Destroy (gameObject);
			//destruir ballenato
			//Destroy (ballena.gameObject);
			//mostrar explosion
			Instantiate(Explosion,transform.position,transform.rotation);
			//Instantiate(Sangre,transform.position,transform.rotation);
			//StartCoroutine (WaitForEndAnimation (2.0f));
			ExplosionClone = GameObject.FindWithTag ("explosion");
			Destroy (ExplosionClone.gameObject,1);
			//gameOver.SetActive (true);
			print ("Estoy muerto");
			//Debug.Log("Estoy muerto");
		}			

	}



	/*
	private  WaitForEndAnimation(float waitTime){
		print ("ingreso");
		//yield return new WaitForSeconds (waitTime);
		print ("Destruir imagen explosion");
		//ExplosionClone = GameObject.FindWithTag ("explosion");
		Destroy (ExplosionClone.gameObject);
		print ("fin");
	}
	*/



	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MovMamaBallena : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		

	}


	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag.Equals("mina") || other.tag.Equals("barco") || other.tag.Equals("tiburon")  ) {			
			Destroy (other.gameObject);
			print ("objeto destruido");
		}
	}


	// Update is called once per frame
	void FixedUpdate () {

	}


}

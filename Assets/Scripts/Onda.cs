using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onda : MonoBehaviour {
	SpriteRenderer render;
	public ClickToMove2 ballenato;
	Color color = new Color(253f,19f,246f,1f);

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, 7);
		transform.Rotate (0, 0, 180);
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.Translate (Vector3.up * Time.deltaTime*20);

	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag.Equals ("ballenagrande")) {
			transform.Rotate (0, 0, 180);
			render = GetComponent<SpriteRenderer> ();
			render.color = Color.red;
			ballenato.messageSad.SetActive (false);
			ballenato.messageHappy.SetActive (true);
		} else {
			ballenato.messageHappy.SetActive (false);
			ballenato.messageSad.SetActive (true);
			//Destroy (this.gameObject, 5);
		}


	}
}

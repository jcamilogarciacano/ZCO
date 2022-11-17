using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderShow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other){
		other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
	//	other.gameObject.transform.Translate (0, 0, 6);

		print ("wenas");
	}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparent : MonoBehaviour
{
	void Start(){
		this.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
	}
	void Update(){
		this.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funciones : MonoBehaviour {
	public GameObject paredsuperior;
	public GameObject paredinferior;
	public GameObject paredizquierda;
	public GameObject paredderecha;


	Vector2 posparedsuperior;
	Vector2 posparedinferior;
	Vector2 posparedderecha;
	Vector2 posparedizquierda;

	// Use this for initialization
	void Start () {
		posparedsuperior  = paredsuperior.transform.position;
		posparedinferior  = paredinferior.transform.position;
		posparedderecha   = paredderecha.transform.position;
		posparedizquierda = paredizquierda.transform.position;


	}
	
	public float[] limitar(float objeto_x,float objeto_y, float objeto_z, float objeto_limit){
		if(objeto_x >= posparedderecha.x){
			objeto_x  -= objeto_limit;
		}else if(objeto_x <= posparedizquierda.x){
			objeto_x  += objeto_limit;
		}

		if(objeto_y >= posparedsuperior.y){
			objeto_y  -= objeto_limit;
		}else if(objeto_y <= posparedinferior.y){
			objeto_y  += objeto_limit;
		}

		float [] salida = new float[3];

		salida [0] = objeto_x;
		salida [1] = objeto_y;
		salida [2] = objeto_z;
		return  salida;

	}

	/*
	void FixedUpdate () {
		
		
	}
	*/

}

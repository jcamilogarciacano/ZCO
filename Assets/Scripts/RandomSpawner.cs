using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour {
	float x_ini;
	float y_ini;
	float z_ini;
	public GameObject mina, barco, tiburon, sonar, ballena;
	public GameObject lechomarino_0, lechomarino_1, lechomarino_2, lechomarino_3, lechomarino_4, lechomarino_5, lechomarino_6;
	int max_mina;
	int max_barco;
	int max_tiburon;
	int max_lechomarino_0;
	int max_lechomarino_1;
	int max_lechomarino_2;
	int max_lechomarino_3;
	int max_lechomarino_4;
	int max_lechomarino_5;
	int max_lechomarino_6;
	int r;
	Vector3 pos;

	// Use this for initialization
	void Start () {
		//ballena
		x_ini = 0;
		y_ini = 0;
		while (Mathf.Abs(x_ini) < 40) {
			x_ini = Random.Range(-70, 70);
		}
		while (Mathf.Abs(y_ini) < 40) {			
			y_ini = Random.Range(-70, 70);
		}
		z_ini = 2;
		pos = new Vector3(x_ini, y_ini, z_ini);
		r = Random.Range(0, 360);
		Quaternion target1 = Quaternion.Euler(0, 0, r);
		Instantiate(ballena,pos,target1);

		//mina
		max_mina = 800;
		for(int i = 0; i< max_mina; i++){
			x_ini = Random.Range(-100, 100);
			y_ini = Random.Range(-100, 100);
			z_ini = 2;
			pos = new Vector3(x_ini, y_ini, z_ini);
			Instantiate(mina,pos,transform.rotation);			
		}

		max_barco = 50;
		for(int i = 0; i< max_barco; i++){
			x_ini = Random.Range(-100, 100);
			y_ini = Random.Range(-100, 100);
			z_ini = 2;
			pos = new Vector3(x_ini, y_ini, z_ini);
			r = Random.Range(0, 360);
			Quaternion target = Quaternion.Euler(0, 0, r);
			Instantiate(barco,pos,target);	
			Instantiate(sonar,pos,transform.rotation);
		}

		max_tiburon = 100;
		for(int i = 0; i< max_tiburon; i++){
			x_ini = Random.Range(-100, 100);
			y_ini = Random.Range(-100, 100);
			z_ini = 2;
			pos = new Vector3(x_ini, y_ini, z_ini);
			r = Random.Range(0, 360);
			Quaternion target = Quaternion.Euler(0, 0, r);
			Instantiate(tiburon,pos,target);			
		}


		max_lechomarino_0 = 400;
		for(int i = 0; i< max_lechomarino_0; i++){
			x_ini = Random.Range(-100, 100);
			y_ini = Random.Range(-100, 100);
			z_ini = 2;
			pos = new Vector3(x_ini, y_ini, z_ini);
			r = Random.Range(0, 360);
			Quaternion target = Quaternion.Euler(0, 0, r);
			Instantiate(lechomarino_0,pos,target);			
		}

		max_lechomarino_1 = 400;
		for(int i = 0; i< max_lechomarino_1; i++){
			x_ini = Random.Range(-100, 100);
			y_ini = Random.Range(-100, 100);
			z_ini = 2;
			pos = new Vector3(x_ini, y_ini, z_ini);
			r = Random.Range(0, 360);
			Quaternion target = Quaternion.Euler(0, 0, r);
			Instantiate(lechomarino_1,pos,target);			
		}

		max_lechomarino_2 = 400;
		for(int i = 0; i< max_lechomarino_2; i++){
			x_ini = Random.Range(-100, 100);
			y_ini = Random.Range(-100, 100);
			z_ini = 2;
			pos = new Vector3(x_ini, y_ini, z_ini);
			r = Random.Range(0, 360);
			Quaternion target = Quaternion.Euler(0, 0, r);
			Instantiate(lechomarino_2,pos,target);			
		}

		max_lechomarino_3 = 400;
		for(int i = 0; i< max_lechomarino_3; i++){
			x_ini = Random.Range(-100, 100);
			y_ini = Random.Range(-100, 100);
			z_ini = 2;
			pos = new Vector3(x_ini, y_ini, z_ini);
			r = Random.Range(0, 360);
			Quaternion target = Quaternion.Euler(0, 0, r);
			Instantiate(lechomarino_3,pos,target);			
		}

		max_lechomarino_4 = 400;
		for(int i = 0; i< max_lechomarino_4; i++){
			x_ini = Random.Range(-100, 100);
			y_ini = Random.Range(-100, 100);
			z_ini = 2;
			pos = new Vector3(x_ini, y_ini, z_ini);
			r = Random.Range(0, 360);
			Quaternion target = Quaternion.Euler(0, 0, r);
			Instantiate(lechomarino_4,pos,target);			
		}
		max_lechomarino_5 = 400;
		for(int i = 0; i< max_lechomarino_5; i++){
			x_ini = Random.Range(-100, 100);
			y_ini = Random.Range(-100, 100);
			z_ini = 2;
			pos = new Vector3(x_ini, y_ini, z_ini);
			r = Random.Range(0, 360);
			Quaternion target = Quaternion.Euler(0, 0, r);
			Instantiate(lechomarino_5,pos,target);			
		}

		max_lechomarino_6 = 400;
		for(int i = 0; i< max_lechomarino_6; i++){
			x_ini = Random.Range(-100, 100);
			y_ini = Random.Range(-100, 100);
			z_ini = 2;
			pos = new Vector3(x_ini, y_ini, z_ini);
			r = Random.Range(0, 360);
			Quaternion target = Quaternion.Euler(0, 0, r);
			Instantiate(lechomarino_6,pos,target);			
		}
	}









	
	// Update is called once per frame
	void Update () {
		
	}
}

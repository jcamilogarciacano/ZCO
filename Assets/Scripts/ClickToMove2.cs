using UnityEngine;
using System.Collections;

public class ClickToMove2 : MonoBehaviour {

	public Vector3 targetPosition;
	public GameObject onda,Sangre;
	public GameObject gameOver;
	public GameObject victory;
	public GameObject Onda;
	public bool lanzarOnda;
	public bool lanzarOnda2;
	public float counter;
	public GameObject oscuridad;
	public GameObject messageHappy;
	public GameObject messageSad;
	float grados;
	void Start(){
		lanzarOnda = false;
	}
	// Update is called once per frame
	void Update () {
		counter++;
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			targetPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			//StartCoroutine (Example());
			lanzarOnda = true;
			counter = 0;
			Vector3 difference = targetPosition - transform.position;
			float rotationZ = Mathf.Atan2 (difference.y, difference.x) * Mathf.Rad2Deg;
			grados = rotationZ + 90;
		} else {
			
		}
	

		transform.rotation = Quaternion.Euler (0.0f, 0.0f,grados);

		//print (transform.rotation.z +" "+rotationZ);
		if (lanzarOnda == true) {
			Instantiate(Onda,transform.position,transform.rotation);	
			lanzarOnda = false;

		}
		if (counter>7) {
			transform.position = Vector2.MoveTowards (transform.position, targetPosition, Time.deltaTime * 5);
		}
		//transform.eulerAngles = new Vector3 (0, 0);
	}
	IEnumerator Example() {
		print("ola soy");
		yield return new WaitForSeconds(0.5f);
	
	}






	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag.Equals("barco") || other.tag.Equals("tiburon") || other.tag.Equals("mina")) {			
			Destroy (this.gameObject);
			Instantiate(Sangre,transform.position,transform.rotation);
			print ("moriste");
			messageHappy.SetActive (false);
			messageSad.SetActive (true);
			oscuridad.SetActive (false);
			gameOver.SetActive (true);
		}			
		if (other.tag.Equals("ballenagrande")) {
			messageSad.SetActive (false);
			messageHappy.SetActive (true);
			oscuridad.SetActive (false);
			victory.SetActive (true);

		}

	}


}

using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;
	//public Transform target;
	void Start(){
		offset = transform.position - player.transform.position;
	}
	// Update is called once per frame
	void Update () 
	{
		
		transform.position = player.transform.position + offset;
	}
}
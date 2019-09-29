using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetPlayerOnTutorial : MonoBehaviour {

	public GameObject Player;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerEnter2D (Collider2D trigger ){
		if (trigger.gameObject.tag == "Player") {
			trigger.transform.position = new Vector3 (0.0f,3.0f, 0.0f);
		} else {
			trigger.gameObject.transform.position = new Vector3 (-9.29f, -6.0f, 0);
		}
	}
	void OnCollisionEnter2D (Collision2D collider ){
		if (collider.gameObject.tag == "Player") {
			collider.transform.position = new Vector3 (0.0f,3.0f, 0.0f);
		} else {
			collider.gameObject.transform.position = new Vector3 (-9.29f, -6.0f, 0);
		}
			
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balltohole : MonoBehaviour {

	// Use this for initialization
	public float gravityRate;
	public Transform target;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float step = Time.deltaTime * gravityRate;
		this.transform.position = Vector3.MoveTowards (this.transform.position, target.position, step);
	}
}

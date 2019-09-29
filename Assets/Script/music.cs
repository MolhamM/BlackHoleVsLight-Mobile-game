using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour {

	public AudioClip boost;
	public AudioClip deboost;
	public AudioClip flash;
	public AudioClip slug;
	public AudioClip giant;
	public AudioClip atom;
	public AudioClip poison;
	public AudioClip dou;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D trigger ){
		if (trigger.gameObject.tag == "Player") {
			if(this.gameObject.tag == "boost")
				AudioSource.PlayClipAtPoint (boost, this.transform.position);
			else if (this.gameObject.tag=="harm")
				AudioSource.PlayClipAtPoint (deboost, this.transform.position);
			else if (this.gameObject.tag=="AtomPhase")
				AudioSource.PlayClipAtPoint (atom, this.transform.position);
			else if (this.gameObject.tag=="double")
				AudioSource.PlayClipAtPoint (dou, this.transform.position);
			else if (this.gameObject.tag=="Flash")
				AudioSource.PlayClipAtPoint (flash, this.transform.position);
			else if (this.gameObject.tag=="GiantPhase")
				AudioSource.PlayClipAtPoint (giant, this.transform.position);
			else if (this.gameObject.tag=="Poison")
				AudioSource.PlayClipAtPoint (poison, this.transform.position);
			else if (this.gameObject.tag=="Slug")
				AudioSource.PlayClipAtPoint (slug, this.transform.position);
		}
	}
}

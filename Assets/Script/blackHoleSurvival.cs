using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class blackHoleSurvival : MonoBehaviour {
	public StateManger stateManger;
	int playerCounter;
	public keyToPortal keytoPorScript;
	public void Awake(){
		Application.targetFrameRate = 60;
	}
	public void Update(){
		checkPlayer ();
	}
	void OnTriggerEnter2D (Collider2D trigger ){
		if (trigger.gameObject.tag == "Key") {
			keytoPorScript.OpenPortal ();
			keytoPorScript.DestroyMe ();
		}
		print ("collision black1");
		if(SceneManager.GetActiveScene().name!="legendSurvival"||SceneManager.GetActiveScene().name!="normSurvival"||SceneManager.GetActiveScene().name!="_Menu")
			this.transform.localScale += new Vector3(.01f,.01f);
		else{
			if (this.transform.localScale.x < 3.5) {
				
				this.transform.localScale += new Vector3(.01f,.01f);
			}
		}
		if(trigger.gameObject.tag!="keyPortal")
			Destroy(trigger.gameObject);
	}
	void OnCollisionEnter2D (Collision2D collider ){
		if (collider.gameObject.tag == "Key") {
			keytoPorScript.OpenPortal ();
			keytoPorScript.DestroyMe ();
		}
		print ("collision black2");
		if (this.transform.localScale.x < 3.5) {

			this.transform.localScale += new Vector3(.01f,.01f);
		}
		if(collider.gameObject.tag!="keyPortal")
			Destroy(collider.gameObject);
	}
	void checkPlayer (){
		playerCounter = 0;
		GameObject[] players = GameObject.FindGameObjectsWithTag ("Player");
		foreach (GameObject player in players) {
			playerCounter++;
		}
		if(SceneManager.GetActiveScene().name!="_Menu")
			if (playerCounter == 0) {
				stateManger.LoadState ("LoseScene");
			}
	}
}
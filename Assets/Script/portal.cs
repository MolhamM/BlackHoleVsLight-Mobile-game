using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portal : MonoBehaviour {
	static int winState;
	public Sprite OpenedPortal;
	bool isOpen=false;
	public StateManger stateManger;
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == OpenedPortal) {
			isOpen = true;
			this.gameObject.GetComponent<PolygonCollider2D> ().isTrigger = true;
			//BoxCollider2D[] childs = this.gameObject.GetComponentInChildren<BoxCollider2D> () as BoxCollider2D;
			foreach (Transform child in transform){
				child.gameObject.GetComponent<BoxCollider2D> ().isTrigger = true;
			}
		}
	}
	void OnTriggerEnter2D (Collider2D trigger ){
		if (isOpen) {
			if (trigger.gameObject.tag == "Player") {
				if (mode.getMode() == "Normal") {
						stateManger.LoadState ("WinNormal");
					}
					else if (mode.getMode() == "Ninja") {
						stateManger.LoadState ("WinInsane");
					}
					else {

						stateManger.LoadState ("WinScene");
					}
				}
			}
		}
	void OnCollisionEnter2D (Collision2D collider ){
		if (isOpen) {
			if (collider.gameObject.tag == "Player") {
				if (mode.getMode() == "Normal") {
					stateManger.LoadState ("WinNormal");
				} 
				else if (mode.getMode() == "Ninja") {
					stateManger.LoadState ("WinInsane");
				}
				else {

					stateManger.LoadState ("WinScene");
				}
			}
		}
	}
	public	static int getState(){
		return winState;
	}
	public static void setState(int x){
		winState = x;
	}
}
/*
	void OnTriggerEnter2D (Collider2D trigger ){
		print (trigger.gameObject.tag);
		if (trigger.gameObject.tag != "Player") {
			print ("ignoring " + trigger.gameObject.tag);
			Physics2D.IgnoreCollision (this.GetComponent<CircleCollider2D> (), trigger.GetComponent<CircleCollider2D> ());
		} else {
			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == OpenedPortal) {	
				print ("ignoring1 " + trigger.gameObject.tag);
				Physics2D.IgnoreCollision (this.GetComponent<CircleCollider2D> (), trigger.GetComponent<CircleCollider2D> ());
			} else {
				print ("blocking"+ trigger.gameObject.tag);
			}
		}

	}*/

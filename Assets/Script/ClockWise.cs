using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockWise : MonoBehaviour {
	public SpriteRenderer spRenderer;
	static bool isClicked;
	void Start(){
		isClicked = false;
		spRenderer = this.GetComponent<SpriteRenderer> ();
	}
	public static bool IsMouseDown(){
		return isClicked;
	}
	public void setClickTrue(){
		isClicked = true;
		spRenderer.color = Color.white;
	}
	public void setClickFalse(){
		isClicked = false;
		spRenderer.color = Color.grey;
	}
}

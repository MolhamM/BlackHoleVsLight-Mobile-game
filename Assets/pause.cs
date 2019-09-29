using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour {



	void Update () {
		
	}
	public void PauseAndPlay(){
		if (Time.timeScale != 0)
			Time.timeScale = 0;
		else
			Time.timeScale = 1.5f;
	}
}

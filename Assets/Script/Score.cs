using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	static int  myscore;
	float fps;
	public Text text;
	public Text fpsText;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		checkFps ();
		checkScore ();

		
	}
	void checkFps(){
		fps =(int)( 1 / Time.deltaTime);
		if (fpsText != null)
			fpsText.text = fps.ToString ();
	}
	void checkScore(){
		myscore = blackHole.getScore()/10;
		if (text != null)
			text.text = myscore.ToString ();
	}
}

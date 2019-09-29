using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class blackHole : MonoBehaviour {
	public StateManger stateManger;
	int playerCounter;
	static int  playerScore;
	public Text text;
	public void Start(){
		playerScore = 0;
	}
	public void Awake () {
		QualitySettings.vSyncCount = 0;
		Application.targetFrameRate=300;
		steadyFps ();
	}
	public void Update(){
		checkPlayer ();
		CalculateScore ();
//		print ("fps :"+1 / Time.deltaTime);
	}
	void steadyFps(){
		Application.targetFrameRate = 60;
		QualitySettings.vSyncCount = 0;
		QualitySettings.antiAliasing = 0;
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
	void OnTriggerEnter2D (Collider2D trigger ){
		if (SceneManager.GetActiveScene ().name == "legendSurvival" || SceneManager.GetActiveScene ().name == "normSurvival" 
			|| SceneManager.GetActiveScene ().name == "_Menu"||SceneManager.GetActiveScene ().name == "ballMotion") {
			if (this.transform.localScale.x < 3.5) {
				this.transform.localScale += new Vector3 (.01f, .01f);
			} 
		}
		else{
			this.transform.localScale += new Vector3 (.01f, .01f);
		}
		if (trigger.gameObject.tag != "keyPortal") {
			Destroy (trigger.gameObject);
		}
	}
	void OnCollisionEnter2D (Collision2D collider ){
		this.transform.localScale += new Vector3(.01f,.01f);
		if (collider.gameObject.tag != "keyPortal") {
			Destroy (collider.gameObject);
		}
	}
	void checkPlayer (){
		playerCounter = 0;
		GameObject[] players = GameObject.FindGameObjectsWithTag ("Player");
		foreach (GameObject player in players) {
			playerCounter++;
		}
		if(SceneManager.GetActiveScene().name!="_Menu" && SceneManager.GetActiveScene().name!="ballMotion")
		if (playerCounter == 0) {
			if (mode.getMode () == "Normal") {
				stateManger.LoadState ("LoseNormal");
			} else if (mode.getMode () == "Ninja") {
				stateManger.LoadState ("LoseInsane");
			} else {

				stateManger.LoadState ("LoseScene");
			}
		}
	}
	void CalculateScore(){
		playerScore+=plazmaBall.getScore ();
		if(text != null )
		text.text =playerScore.ToString ();
	}
	public static int getScore(){
		return playerScore;
	}
}
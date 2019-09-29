using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackgroundSound : MonoBehaviour {

	public static BackgroundSound instance= null;
	public AudioClip NormalClip;
	public AudioClip NinjaClip;
	public AudioClip WinClip;
	public AudioClip LoseClip;
	public AudioClip MenuClip;
	public AudioClip SurvivalNormClip;
	public AudioClip SurvivalLegendClip;
	public bool IsChoose;
	AudioSource audioSource;
	bool IsWinPlayed;
	bool IsLosePlayed;
	void Start () {
		IsChoose = false;
		IsWinPlayed = false;
		IsLosePlayed = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (IsChoose) 
			DontDestryOnChooseScene ();
		else if (SceneManager.GetActiveScene ().name != "Choose" ){
			DestroyChooseInstance ();
			audioSource = this.GetComponent<AudioSource> ();
			if (!audioSource.isPlaying) {
				loadClip ();
			}
		}
	}
	void loadClip(){
		print ("here " + mode.getMode ());
		if (SceneManager.GetActiveScene ().name == "_Menu" || SceneManager.GetActiveScene ().name == "ballMotion" ||
			SceneManager.GetActiveScene ().name == "survival"||SceneManager.GetActiveScene ().name == "Choose")
			audioSource.PlayOneShot (MenuClip, .4f);
		else if (SceneManager.GetActiveScene ().name == "WinNormal" || SceneManager.GetActiveScene ().name == "winInsane" ||
		         SceneManager.GetActiveScene ().name == "WinScene") {
			if(!IsWinPlayed)
				audioSource.PlayOneShot (WinClip, 1.0f);
			IsWinPlayed= true;
		}
		else if (SceneManager.GetActiveScene ().name == "LoseScene" || SceneManager.GetActiveScene ().name == "LoseInsane" ||
		         SceneManager.GetActiveScene ().name == "LoseNormal") {
			if(!IsLosePlayed)
			audioSource.PlayOneShot (LoseClip, 1.0f);
			IsLosePlayed= true;
		}
		else if (SceneManager.GetActiveScene ().name == "normSurvival" )
			audioSource.PlayOneShot (SurvivalNormClip,1.0f);
		else if (SceneManager.GetActiveScene ().name == "legendSurvival" )
			audioSource.PlayOneShot (SurvivalLegendClip,1.0f);
		else if (SceneManager.GetActiveScene ().name == "easyNormal"||SceneManager.GetActiveScene ().name == "hardNormal"||SceneManager.GetActiveScene ().name == "midNormal" )
			audioSource.PlayOneShot (NormalClip,1.0f);
		else if (SceneManager.GetActiveScene ().name == "easeyInsane"||SceneManager.GetActiveScene ().name == "hardInsane"||SceneManager.GetActiveScene ().name == "midInsane")
			audioSource.PlayOneShot (NinjaClip,1.0f);
	}
	void DontDestryOnChooseScene(){
		instance = this;
		DontDestroyOnLoad (this);
		audioSource = this.GetComponent<AudioSource> ();
		if (!audioSource.isPlaying) {
			loadClip ();
		}
	}
	void DestroyChooseInstance(){
		IsChoose = false;
		if(instance!=null)
			Destroy (instance.gameObject);
	}
	public void ChangeChooseBool(bool x){
		IsChoose = x;
	}

}

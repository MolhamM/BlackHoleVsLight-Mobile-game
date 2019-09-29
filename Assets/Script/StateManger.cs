using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StateManger : MonoBehaviour {

	public void LoadState (string name ) {
		/*if (name == "Choose") {
			GameObject[] objs = GameObject.FindGameObjectsWithTag("SoundBackground");
			DontDestroyOnLoad (objs);
		}*/
		if (name == "wonInNormal") {
			if (portal.getState() == 1) {
				SceneManager.LoadScene ("midNormal");
			}
			if (portal.getState() == 2) {
				SceneManager.LoadScene ("hardNormal");
			}
			if (portal.getState ()== 3) {
				SceneManager.LoadScene ("easeyInsane");
			}
		}
		else if (name == "wonInInsane") {
			if (portal.getState() == 1) {
				SceneManager.LoadScene ("midInsane");
			}
			if (portal.getState() == 2) {
				SceneManager.LoadScene ("hardInsane");
			}
			if (portal.getState ()== 3) {
				SceneManager.LoadScene ("survival");
			}
		}
		else {
			Debug.Log ("State load requsted for  : " + name);
			SceneManager.LoadScene (name);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
	
public class mode : MonoBehaviour {
	static string currentMode;
	void Update(){
		if (SceneManager.GetActiveScene ().name == "easeyInsane" || SceneManager.GetActiveScene ().name == "midInsane" ||
		    SceneManager.GetActiveScene ().name == "hardInsane") {
			currentMode = "Ninja";
			if (SceneManager.GetActiveScene ().name == "easeyInsane") {
				portal.setState (1);
				print ("mode : easy insane");
			} else if (SceneManager.GetActiveScene ().name == "midInsane") {

				portal.setState (2);
				print ("mode : mid insane");
			}
			else if (SceneManager.GetActiveScene ().name == "hardInsane")
				portal.setState (3);
		}
		if (SceneManager.GetActiveScene ().name == "easyNormal" || SceneManager.GetActiveScene ().name == "midNormal" ||
			SceneManager.GetActiveScene ().name == "hardNormal") {
			currentMode = "Normal";
			if (SceneManager.GetActiveScene ().name == "easyNormal")
				portal.setState (1);
			else if (SceneManager.GetActiveScene ().name == "midNormal")
				portal.setState (2);
			else if (SceneManager.GetActiveScene ().name == "hardNormal")
				portal.setState (3);
		}
		if (SceneManager.GetActiveScene ().name == "survival"||SceneManager.GetActiveScene ().name == "legendSurvival"
			||SceneManager.GetActiveScene ().name == "normSurvival")
			currentMode = "Survival";
	}

	public static string getMode(){
		return currentMode;
	}

}

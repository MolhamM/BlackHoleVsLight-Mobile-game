using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NinjaWin : MonoBehaviour {

	public Text text;
	public Text text2;
	void Start () {
		print (portal.getState ());
		if (portal.getState () == 1) 
			text.text="Ninja:easy";
		if (portal.getState () == 2)
			text.text="Ninja:mid";
		if (portal.getState () == 3) {
			text.text="Ninja:hard";
			text2.text = "TRY Survival >>";
		}

	}

	// Update is called once per frame
	void Update () {
	}
}

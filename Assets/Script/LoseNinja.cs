using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LoseNinja : MonoBehaviour {

	public Text text;	
	void Start () {
		if (portal.getState () == 1)
			text.text="Ninja:easy";
		if (portal.getState () == 2)
			text.text="Ninja:mid";
		if (portal.getState () == 3) {
			text.text="Ninja:hard";
		}

	}

	// Update is called once per frame
	void Update () {
	}
}

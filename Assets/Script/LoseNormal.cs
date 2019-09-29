using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LoseNormal : MonoBehaviour {

	public Text text;	
	void Start () {
		if (portal.getState () == 1)
			text.text="Normal:easy";
		if (portal.getState () == 2)
			text.text="Normal:mid";
		if (portal.getState () == 3) {
			text.text="Normal:hard";
		}

	}

	// Update is called once per frame
	void Update () {
	}
}

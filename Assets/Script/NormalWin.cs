using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NormalWin : MonoBehaviour {

	public Text text;
	public Text text2;
	void Start () {
		if (portal.getState () == 1)
			text.text="Normal:easy";
		if (portal.getState () == 2)
			text.text="Normal:mid";
		if (portal.getState () == 3) {
			text.text="Normal:hard";
			text2.text = "TRY NINJA >>";
		}
			
	}
	
	// Update is called once per frame
	void Update () {
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTouch : MonoBehaviour {

	public GameObject clockWiseCollision;
	public GameObject AntiClockWiseCollision;
	void Update () {
		if(Input.touchCount > 0){
			foreach (Touch touch in Input.touches) {
				if (touch.phase != TouchPhase.Ended) {
					Vector3 wp = Camera.main.ScreenToWorldPoint (touch.position);
					Vector2 touchPos = new Vector2 (wp.x, wp.y);
					if (clockWiseCollision.GetComponent<BoxCollider2D> () == Physics2D.OverlapPoint (touchPos)) {
						clockWiseCollision.GetComponent<ClockWise> ().setClickTrue ();
					} else {
						clockWiseCollision.GetComponent<ClockWise> ().setClickFalse ();
					}
					if (AntiClockWiseCollision.GetComponent<BoxCollider2D> () == Physics2D.OverlapPoint (touchPos)) {
						AntiClockWiseCollision.GetComponent<AntiClockWise> ().setClickTrue ();
					} else {
						AntiClockWiseCollision.GetComponent<AntiClockWise> ().setClickFalse ();
					}
				} else {
					clockWiseCollision.GetComponent<ClockWise> ().setClickFalse ();
					AntiClockWiseCollision.GetComponent<AntiClockWise> ().setClickFalse ();
				}
			}
		}
	}
}

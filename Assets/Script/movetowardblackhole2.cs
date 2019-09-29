using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movetowardblackhole2 : MonoBehaviour {

	// Use this for initialization
	private Transform target;
	public float SA_NormalEasy;
	public float SA_NormalMid;
	public float SA_NormalHard;
	public float SA_InsaneEasy;
	public float SA_InsaneMid;
	public float SA_InsaneHard;
	public float Menu;
	public float Tutorial;
	float strengthOfAttraction;
	private Rigidbody2D rb;
	double holeToBlackDistance;
	void Start () {
		strengthOfAttraction = 0;
		if (SceneManager.GetActiveScene ().name == "easyNormal") {
			strengthOfAttraction = SA_NormalEasy;

		} else if (SceneManager.GetActiveScene ().name == "midNormal"||SceneManager.GetActiveScene ().name == "normSurvival") {
			strengthOfAttraction = SA_NormalMid;

		}
		else if (SceneManager.GetActiveScene ().name == "hardNormal") {
			strengthOfAttraction = SA_NormalHard;

		}
		else if (SceneManager.GetActiveScene ().name == "easeyInsane") {
			strengthOfAttraction = SA_InsaneEasy;

		}
		else if (SceneManager.GetActiveScene ().name == "midInsane"||SceneManager.GetActiveScene ().name == "legendSurvival") {
			strengthOfAttraction = SA_InsaneMid;

		}else if (SceneManager.GetActiveScene ().name == "hardInsane") {
			strengthOfAttraction = SA_InsaneHard;

		}else if (SceneManager.GetActiveScene ().name == "_Menu") {
			strengthOfAttraction = Menu;

		}
		else if (SceneManager.GetActiveScene ().name == "ballMotion") {
			strengthOfAttraction = Tutorial;

		}
		target = GameObject.Find ("blackhole").transform;
		holeToBlackDistance = Mathf.Sqrt(Mathf.Pow ((target.transform.position.x - this.transform.position.x), 2)
			+Mathf.Pow ((target.transform.position.y - this.transform.position.y), 2)); 

		rb = this.GetComponent<Rigidbody2D> ();	
		//float rand = Random.Range (5f, 0.5f);
		Vector3 direction = target.position - this.transform.position;
		rb.AddForce ((float )(strengthOfAttraction/holeToBlackDistance)*direction );
	}

}

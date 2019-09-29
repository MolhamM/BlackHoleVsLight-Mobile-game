using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class plazmaBall : MonoBehaviour {
	
	public Transform blackhole;
	float x,y;
	static int score;
	float counter;
	double holeToBlackDistance;
	float timerBoost;
	float timerHarm;
	bool IscollideBoost=false;
	bool IscollideHarm=false;
	public float strengthOfAttraction;
	private Rigidbody2D rb;
	public float boostMagnitude;
	public int harmMagnitude;
	//public CircleCollider2D coll;
	public float movementSpeed;
	// atom and giant
	//public float AtomRate;
	public float AtomTimer;
	bool IsAtomCollision;
	//public float GiantRate;
	public float GiantTimer;
	bool IsGiantCollision;
	//flash and slug
	bool IsFlash;
	public float flashTimer;
	//public float flashRate;
	bool IsSlug;
	public float slugTimer;
	//public float slugRate;
	//poison
	bool IsPoisioned;
	public float poisonTimer;
	//public float PoisonRate;
	//teleport
	Vector3 teleportPos;
	GameObject otherteledes;
	//dou
	bool IsDou;
	float xForClone;
	float yForClone;
	public void Start () {
		counter = 0;
		IsAtomCollision = false;
		IsGiantCollision = false;
		IsFlash = false;
		IsSlug = false;
		IsDou = false;
		IsPoisioned = false;
		holeToBlackDistance = Math.Sqrt(Math.Pow ((blackhole.transform.position.x - this.transform.position.x), 2)
			+Math.Pow ((blackhole.transform.position.y - this.transform.position.y), 2)); 
		x = Mathf.Sin (counter) * (float)holeToBlackDistance;
		y = Mathf.Cos (counter) * (float)holeToBlackDistance;
		rb = this.GetComponent<Rigidbody2D> ();
		timerBoost = 0;
		timerHarm = 0;
		IscollideBoost = false;
		IscollideHarm = false;
		// initialValues
		this.gameObject.GetComponent<SpriteRenderer>().color= Color.white;
		score = 0;
	}

	void Update (){
		touchScreen ();
		circularMotion();
		addingForce ();
		movingTowardBlackHole ();
		DuoPlayer ();
	}
	void touchScreen(){
		foreach (Touch touch in Input.touches) {
			print (touch.position);
		}
	}
	void OnTriggerEnter2D (Collider2D trigger ){
		if (trigger.gameObject.tag == "boost") {
			rb.velocity = new Vector3 (0.0f, 0.0f, 0.0f);
			timerBoost = 0;
			IscollideBoost = true;
			score += 100;
		}
		if (trigger.gameObject.tag == "harm") {
			rb.velocity = new Vector3 (0.0f, 0.0f, 0.0f);
			timerHarm = 0;
			IscollideHarm = true;
		}
		if (trigger.gameObject.tag == "AtomPhase") {
			this.transform.localScale = (this.transform.localScale / 1.5f);
			StartCoroutine(AtomPlayer ());
			IsAtomCollision = true;
			score += 200;
		}
		if (trigger.gameObject.tag == "GiantPhase") {
			SteppingGiantback ();
			this.transform.localScale = (this.transform.localScale * 1.5f);
			StartCoroutine(GiantPlayer ());
			IsGiantCollision = true;
			score += 200;
		}
		if (trigger.gameObject.tag == "Flash") {
			movementSpeed *= 2;
			StartCoroutine(FlashPlayer ());
			IsFlash = true;
			score += 200;
		}
		if (trigger.gameObject.tag == "Slug") {
			movementSpeed /= 2;
			StartCoroutine(SlugPlayer ());
			IsSlug = true;
		}
		if (trigger.gameObject.tag == "Poison") {
			IsPoisioned = true;
			StartCoroutine(PoisonedPlayer ());
		}
		if (trigger.gameObject.tag == "double") {
			Instantiate (this.gameObject.transform.parent, new Vector3 (0.0f , 0.0f , 0.0f ), Quaternion.identity);
			IsDou = true;
			DuoPlayer ();
			score += 300;
		}

		if (trigger.tag == ("boost") || trigger.tag == ("harm") ||
			trigger.tag == ("AtomPhase") || trigger.tag == ("GiantPhase") || trigger.tag == ("Flash")||trigger.tag == ("Slug")||
			trigger.tag == ("Poison")||trigger.tag==("double") ) 
		{
			Destroy(trigger.gameObject);
		}

	}

	void circularMotion(){
		score += (int)(movementSpeed/3);
		this.transform.rotation=new Quaternion(0.0f,0.0f,0.0f,0.0f);
		if (IsPoisioned) {
			poisonedMovement ();
		}
		else{
			normalMovement ();
		}
		holeToBlackDistance = Math.Sqrt(Math.Pow ((blackhole.transform.position.x - this.transform.position.x), 2)
			+Math.Pow ((blackhole.transform.position.y - this.transform.position.y), 2));
		x = Mathf.Sin (counter) * (float)holeToBlackDistance;
		y = Mathf.Cos (counter) *(float) holeToBlackDistance;
		Vector3 rotation = new Vector3 (x, y, 0);
		transform.position = rotation;
	}
	void poisonedMovement(){
		if (IsDou) {
			if (ClockWise.IsMouseDown())
				counter += Time.deltaTime * movementSpeed;
			if (AntiClockWise.IsMouseDown())
				counter -= Time.deltaTime * movementSpeed;
		} else {
			if (ClockWise.IsMouseDown()) 
				counter -= Time.deltaTime*movementSpeed;
			if (AntiClockWise.IsMouseDown()) 
				counter += Time.deltaTime*movementSpeed;
		}
	}
	void normalMovement(){
		if (IsDou) {
			if (ClockWise.IsMouseDown()) 
				counter -= Time.deltaTime*movementSpeed;
			if (AntiClockWise.IsMouseDown()) 
				counter += Time.deltaTime*movementSpeed;
		} else {
			if (ClockWise.IsMouseDown()) 
				counter += Time.deltaTime*movementSpeed;
			if (AntiClockWise.IsMouseDown()) 
				counter -= Time.deltaTime*movementSpeed;
		}
	}
	void addingForce(){
		if (IscollideBoost) {
			timerBoost += Time.deltaTime;
			if (timerBoost < .6) {
			rb.AddForce ( this.transform.position* boostMagnitude);
			} else {
				timerBoost = 0;
				IscollideBoost = false;
					
			}
		}
			if (IscollideHarm) {
				timerHarm += Time.deltaTime;
				if (timerHarm < .6) {

			rb.AddForce ( this.transform.position * -harmMagnitude);
				} else {
					timerHarm = 0;
					IscollideHarm = false;

				}
			}
	}
	void movingTowardBlackHole(){
		if (!IscollideHarm && !IscollideBoost) {
			Vector3 direction = blackhole.position - this.transform.position;
			this.gameObject.GetComponent<Rigidbody2D>().AddForce (strengthOfAttraction *direction);
			this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3 (0.0f, 0.0f, 0.0f);
			}
		}
	void SteppingGiantback(){
		/*Vector3 direction = blackhole.position - this.transform.position;
		rb.AddForce (strengthOfAttraction *direction);
		rb.velocity = new Vector3 (0.0f, 0.0f, 0.0f);*/
		this.transform.position = Vector3.MoveTowards (this.transform.position, blackhole.position, 0.2f);
	}
	IEnumerator AtomPlayer () {
		yield return new WaitForSeconds (AtomTimer);
		this.transform.localScale = (this.transform.localScale * 1.5f);
		IsAtomCollision = false;

		/*if (IsAtomCollision) {
			
			AtomTimer += Time.deltaTime;
			if (AtomTimer > AtomRate) {
				this.transform.localScale = (this.transform.localScale * 1.5f);
				IsAtomCollision = false;
				AtomTimer = 0;
			}
		}*/
	}
	IEnumerator GiantPlayer () {
		yield return new WaitForSeconds (GiantTimer);
		this.transform.localScale = (this.transform.localScale / 1.5f);
		IsGiantCollision = false;
		/*if (IsGiantCollision) {
			GiantTimer += Time.deltaTime;
			if (GiantTimer > GiantRate) {
				this.transform.localScale = (this.transform.localScale / 1.5f);
				IsGiantCollision = false;
				GiantTimer = 0;
			}
		}*/
	}
	IEnumerator FlashPlayer(){
		yield return new WaitForSeconds (flashTimer);
		movementSpeed /= 2;
		IsFlash = false;
		/*
		if (IsFlash) {

			flashTimer += Time.deltaTime;
			if (flashTimer > flashRate) {
				movementSpeed /= 2;
				IsFlash = false;
				flashTimer= 0;
			}
		}*/
	}
	IEnumerator SlugPlayer(){
		yield return new WaitForSeconds (slugTimer);
		movementSpeed *= 2;
		IsSlug = false;
		
		/*
		if (IsSlug) {

			slugTimer += Time.deltaTime;
			if (slugTimer > slugRate) {
				movementSpeed *= 2;
				IsSlug = false;
				slugTimer= 0;
			}
		}*/
	}
	IEnumerator PoisonedPlayer(){
		yield return new WaitForSeconds (poisonTimer);
		IsPoisioned = false;
		/*
		poisonTimer += Time.deltaTime;
		if (poisonTimer > PoisonRate) {
			IsPoisioned = false;
			poisonTimer= 0;
		}*/
	}
	void DuoPlayer(){
		ignoreDuoCollider ();
		int playerCounter = 0;
		GameObject[] players = GameObject.FindGameObjectsWithTag ("Player");
		foreach (GameObject player in players) {
			playerCounter++;
		}
		if (playerCounter == 1 ) {
			IsDou = false;
		}
	}
	void ignoreDuoCollider(){
		GameObject[] players = GameObject.FindGameObjectsWithTag ("Player");
		foreach (GameObject player in players) {
			if (player != this.gameObject) {
				Physics2D.IgnoreCollision (player.transform.GetComponent<CircleCollider2D> (), this.GetComponent<CircleCollider2D> ());
			}
		}
	}
	public static int  getScore(){
		return score;
	}
	public float getMovementSpeed(){
		return movementSpeed;
	}
	public void SetMovementSpeed(float newMovmentSpeed){
		movementSpeed = newMovmentSpeed;
	}
	public bool getFlash(){
		return IsFlash;
	}
	public bool getSlug(){
		return IsSlug;
	}
	public bool getPoison(){
		return IsPoisioned;
	}
	public bool getGiant(){
		return IsGiantCollision;
	}
	public bool getAtom(){
		return IsAtomCollision;
	}
}
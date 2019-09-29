using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiating : MonoBehaviour {
	//booost / harm
	public GameObject boostPrefab;
	public GameObject harmPrefab;
	//GameObject boostInstance;
	GameObject harmInstance;
	Vector3 boostPos ;
	Vector3 harmPos;
	int randomChoice;
	int boostCounter;
	int harmCounter;
	float x,y;
	//int wait;
	public int wait;
	// Atom and Giant
	public float AtomandGiantRangeTimer;
	public float AtomandGiantRangeTimer2;
	float AtomandGianttimer;
	//float AtomandGiantRate;
	public GameObject Atom;
	public GameObject Giant;
	int reverse;
	Vector3 randomall;
	//int randomAtomAndGaint;
	// flash and slug
	public float flashandSlugTimerRange;
	public float flashandSlugTimerRange2;
	public GameObject flash;
	public GameObject slug;
	float flashandSlugTimer;
	//float flashandSlugRate;
	// poison
	public float PoisonTimerRange;
	public float PoisonTimerRange2;
	public GameObject poison;
	float PoisonTimer;
	//float PoisonRate;
	//double
	public GameObject dou;
	float douTimer;
	public float DoubleTimerRange;
	public float DoubleTimerRange2;
	//float douRate;
	public void Awake () {
		Application.targetFrameRate = 60;
	}
	void Start () {
		//wait = 0;
		boostCounter = 0;
		harmCounter = 0;
		douTimer = 0;
		flashandSlugTimer = 0;
		x = Random.Range (-10.0f, -7.0f);
		y = Random.Range (0.0f, 5.0f);
		PoisonTimer = 0;
		makeTimer ();
		makeTimerOfPoison ();
		makeTimerofSlugAndFlash ();
		makeTimerOfDouble ();
		makeTimerOfAtomAndGiant ();
	}

	// Update is called once per frame
	void Update () {
		
	}
	void makeTimer (){
		StartCoroutine (makeInstance ());
	}
	void makeTimerOfAtomAndGiant (){
		AtomandGianttimer = Random.Range (AtomandGiantRangeTimer, AtomandGiantRangeTimer2);
		StartCoroutine (makeInstanceOfAtomAndGaint ());
	}
	void makeTimerOfPoison (){
		PoisonTimer = Random.Range (PoisonTimerRange, PoisonTimerRange2);
		StartCoroutine (makeInstanceOfPoison());
	}
	void makeTimerofSlugAndFlash (){
		flashandSlugTimer = Random.Range (flashandSlugTimerRange, flashandSlugTimerRange2);
		StartCoroutine (makeInstanceOfFlashOrSlug ());
	}
	void makeTimerOfDouble (){
		douTimer = Random.Range (DoubleTimerRange, DoubleTimerRange2);
		StartCoroutine (makeInstanceOfDou());
	}
	IEnumerator makeInstance ()
	{
		while (true) {
			for (int yOtherSide = 1; yOtherSide >= -1; yOtherSide -= 2) {

				for (int xOtherSide = 1; xOtherSide >= -1; xOtherSide -= 2) {

					for (int i = 0; i < 2; i++) {
						randomChoice = Random.Range ((int)1, (int)3);
						x = Random.Range (-100.0f, -7.0f);
						y = Random.Range (0.0f, 5.0f);
						if (randomChoice == 1 && boostCounter < 4) {
							boostCounter++;
							boostPos = new Vector3 (x * xOtherSide, y * yOtherSide, 0);
							//boostInstance = 
							Instantiate (boostPrefab, boostPos, Quaternion.identity);//as GameObject;

						} else {
							if (harmCounter < 4) {
								harmCounter++;
								harmPos = new Vector3 (x * xOtherSide, y * yOtherSide, 0);
								///harmInstance = 
								Instantiate (harmPrefab, harmPos, Quaternion.identity);
								//print ("harm instantiated ");
							} else {
								boostCounter++;
								boostPos = new Vector3 (x * xOtherSide, y * yOtherSide, 0);
								Instantiate (boostPrefab, boostPos, Quaternion.identity);
								//print ("Boost instantiated2 ");
							}
						}
					}
				}
			}
			boostCounter = 0;
			harmCounter = 0;	
			for (int yOtherSide = 1; yOtherSide >= -1; yOtherSide -= 2) {

				for (int xOtherSide = 1; xOtherSide >= -1; xOtherSide -= 2) {

					for (int i = 0; i < 2; i++) {
						randomChoice = Random.Range ((int)1, (int)3);
						x = Random.Range (-6.0f, 0.0f);
						y = Random.Range (-5.55f, -100f);
						if (randomChoice == 1 && boostCounter < 4) {
							boostCounter++;
							boostPos = new Vector3 (x * xOtherSide, y * yOtherSide, 0);
							//boostInstance = 
							Instantiate (boostPrefab, boostPos, Quaternion.identity);//as GameObject;
							//print ("Boost instantiated ");
						} else {
							if (harmCounter < 4) {
								harmCounter++;
								harmPos = new Vector3 (x * xOtherSide, y * yOtherSide, 0);
								//harmInstance =
								Instantiate (harmPrefab, harmPos, Quaternion.identity);
								//print ("harm instantiated ");
							} else {
								boostCounter++;
								boostPos = new Vector3 (x * xOtherSide, y * yOtherSide, 0);
								//boostInstance = 
								Instantiate (boostPrefab, boostPos, Quaternion.identity);//as GameObject;
								//print ("Boost instantiated2 ");
							}
						}
					}
				}
			}	
			boostCounter = 0;
			harmCounter = 0;
			x = Random.Range (-7.70f, -20f);
			y = Random.Range (5.22f, 20f);
			for (int yOtherSide = 1; yOtherSide >= -1; yOtherSide -= 2) {
				for (int xOtherSide = 1; xOtherSide >= -1; xOtherSide -= 2) {

					randomChoice = Random.Range ((int)1, (int)3);
					if (randomChoice == 1 && boostCounter < 2) {
						boostCounter++;
						boostPos = new Vector3 (x * xOtherSide, y * yOtherSide, 0);
						//boostInstance = 
						Instantiate (boostPrefab, boostPos, Quaternion.identity);//as GameObject;
						//print ("Boost instantiated ");
					} else {
						if (harmCounter < 2) {
							harmCounter++;
							harmPos = new Vector3 (x * xOtherSide, y * yOtherSide, 0);
							//harmInstance =
							Instantiate (harmPrefab, harmPos, Quaternion.identity);
							//print ("harm instantiated ");
						} else {
							boostCounter++;
							boostPos = new Vector3 (x * xOtherSide, y * yOtherSide, 0);
							//boostInstance = 
							Instantiate (boostPrefab, boostPos, Quaternion.identity);//as GameObject;
							//print ("Boost instantiated2 ");
						}
					}
				}
			}
			yield return new WaitForSeconds (wait);
		}
	}
	IEnumerator makeInstanceOfAtomAndGaint (){
		while(true){
				yield return new WaitForSeconds (AtomandGianttimer);
				Vector3 randomPosisionx=new Vector3(Random.Range(-8.0f,-15.0f),Random.Range(-10.0f,10.0f),0);
				Vector3 randomPosisiony=new Vector3(Random.Range(-20.0f,20.0f),Random.Range(-8.0f,-15.0f),0);
				int randomBetweenTwo= Random.Range ((int)1, (int)3);
				switch (randomBetweenTwo) {
				case 1:
					reverse = 1;
					break;
				case 2:
					reverse = -1;
					break;
				}
				randomPosisionx.x *= reverse;
				randomPosisiony.y *= reverse;
				randomBetweenTwo= Random.Range ((int)1, (int)3);
				switch (randomBetweenTwo) {
				case 1:
					randomall = randomPosisionx;
					break;
				case 2:
					randomall = randomPosisiony;
					break;
				}
				randomBetweenTwo = Random.Range ((int)1, (int)3);
				switch (randomBetweenTwo) {
				case 1:
					Instantiate (Atom, randomall, Quaternion.identity);
					break;
				case 2:
					Instantiate (Giant, randomall, Quaternion.identity);
					break;
				}
			}
	}
	IEnumerator makeInstanceOfFlashOrSlug (){
		while(true){
			yield return new WaitForSeconds (flashandSlugTimer);
			Vector3 randomPosisionx = new Vector3 (Random.Range (-8.0f, -15.0f), Random.Range (-10.0f, 10.0f), 0);
			Vector3 randomPosisiony = new Vector3 (Random.Range (-20.0f, 20.0f), Random.Range (-8.0f, -15.0f), 0);
			int randomBetweenTwo = Random.Range ((int)1, (int)3);
			switch (randomBetweenTwo) {
			case 1:
				reverse = 1;
				break;
			case 2:
				reverse = -1;
				break;
			}
			randomPosisionx.x *= reverse;
			randomPosisiony.y *= reverse;
			randomBetweenTwo = Random.Range ((int)1, (int)3);
			switch (randomBetweenTwo) {
			case 1:
				randomall = randomPosisionx;
				break;
			case 2:
				randomall = randomPosisiony;
				break;
			}
			randomBetweenTwo = Random.Range ((int)1, (int)3);
			switch (randomBetweenTwo) {
			case 1:
				Instantiate (flash, randomall, Quaternion.identity);
				break;
			case 2:
				Instantiate (slug, randomall, Quaternion.identity);
				break;
			}
			}
	}
	IEnumerator makeInstanceOfPoison(){
		while(true){
			yield return new WaitForSeconds (PoisonTimer);
			Vector3 randomPosisionx = new Vector3 (Random.Range (-8.0f, -15.0f), Random.Range (-10.0f, 10.0f), 0);
			Vector3 randomPosisiony = new Vector3 (Random.Range (-20.0f, 20.0f), Random.Range (-8.0f, -15.0f), 0);
			int randomBetweenTwo = Random.Range ((int)1, (int)3);
			switch (randomBetweenTwo) {
			case 1:
				reverse = 1;
				break;
			case 2:
				reverse = -1;
				break;
			}
			randomPosisionx.x *= reverse;
			randomPosisiony.y *= reverse;
			randomBetweenTwo = Random.Range ((int)1, (int)3);
			switch (randomBetweenTwo) {
			case 1:
				randomall = randomPosisionx;
				break;
			case 2:
				randomall = randomPosisiony;
				break;
			}
			Instantiate (poison, randomall, Quaternion.identity);
		}
	}
	IEnumerator makeInstanceOfDou(){
		while(true){
			yield return new WaitForSeconds (douTimer);
			Vector3 randomPosisionx = new Vector3 (Random.Range (-8.0f, -15.0f), Random.Range (-10.0f, 10.0f), 0);
			Vector3 randomPosisiony = new Vector3 (Random.Range (-20.0f, 20.0f), Random.Range (-8.0f, -15.0f), 0);
			int randomBetweenTwo = Random.Range ((int)1, (int)3);
			switch (randomBetweenTwo) {
			case 1:
				reverse = 1;
				break;
			case 2:
				reverse = -1;
				break;
			}
			randomPosisionx.x *= reverse;
			randomPosisiony.y *= reverse;
			randomBetweenTwo = Random.Range ((int)1, (int)3);
			switch (randomBetweenTwo) {
			case 1:
				randomall = randomPosisionx;
				break;
			case 2:
				randomall = randomPosisiony;
				break;
			}
			Instantiate (dou, randomall, Quaternion.identity);
		}
	}
}

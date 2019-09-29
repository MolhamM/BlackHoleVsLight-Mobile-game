using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change_1 : MonoBehaviour {

	public GameObject blackHole;
	public GameObject blackHoleWaves;
	public GameObject blackHoleWaves2;
	public GameObject playerParent;
	public GameObject player;
	public GameObject keyPortal;
	public SpriteRenderer mainPortal;
	public SpriteRenderer upperPortal;
	public SpriteRenderer belowPortal;
	public GameObject myInstantiate;
	GameObject myInstatiateInstance;
	public GameObject playerResetter;
	public GameObject playerResetter2;
	public GameObject clockWise;
	public GameObject antiClockWise;
	public GameObject text;
	public GameObject text_;
	public GameObject text__;
	public GameObject text2;
	public GameObject text3;
	public GameObject text4;
	public GameObject text4_;
	public GameObject text4__;
	public GameObject text5;
	public GameObject text6;
	public GameObject text6_;
	public GameObject text7;
	public GameObject text7_;
	public GameObject text8;
	public GameObject text8_;
	public GameObject text9;
	public GameObject text9_;
	public GameObject text10;
	public GameObject text10_;
	public GameObject text11;
	public GameObject text11_;
	public GameObject text11__;
	public GameObject text12;
	public GameObject text12_;
	public GameObject text12__;
	public GameObject text13;
	public GameObject text14;
	public GameObject continueFirst;
	public GameObject continueSec;
	public GameObject continueThird;
	public GameObject continueForth;
	public GameObject continueFifth;
	public GameObject continuesixth;
	public GameObject continueSeventh;
	public GameObject continue8th;
	public GameObject continue9th;
	public GameObject continue10th;
	public GameObject continue11th;
	public GameObject continue12th;
	public GameObject boost;
	public GameObject harm;
	public GameObject flash;
	public GameObject slug;
	public GameObject giant;
	public GameObject atom;
	public GameObject poision;
	public GameObject dou;
	public Sprite mainPortalOpen;
	public Sprite mainPortalClosed;
	public Sprite upperandbelowOpen;
	public Sprite upperandbelowClosed;
	public plazmaBall playerScript;
	public resetPlayerOnTutorial resetScript;
	void Start () {
		SetFirsActive ();
	}


	void Update () {
		if (blackHole.transform.localScale.x != (float)0.4) {
			continueFirst.SetActive (true);
			text_.GetComponent<Text> ().color = Color.white;
			text__.GetComponent<Text> ().color = Color.red;
		}
		if (player.gameObject.transform.position.x != 0) {
			continueSec.SetActive(true);
		}
		if (boost == null) {
			continueThird.SetActive (true);
		}
		if (harm == null) {
			text4_.SetActive (false);
			text4__.SetActive (true);
			continueForth.SetActive (true);
		}
		if (dou == null) {
			continueFifth.SetActive (true);
		}
		if (flash == null) {
			if(!playerScript.getFlash())
			continuesixth.SetActive (true);
		}
		if (slug == null) {
			if(!playerScript.getSlug())
			continueSeventh.SetActive (true);
		}
		if (poision == null) {
			if(!playerScript.getPoison())
			continue8th.SetActive (true);
		}
		if (giant == null) {
			if(!playerScript.getGiant())
			continue9th.SetActive (true);
		}
		if (atom == null) {
			if(!playerScript.getAtom())
			continue10th.SetActive (true);
		}
		if (mainPortal.sprite == mainPortalClosed) {
			continue11th.SetActive (true);
		}
		if (mainPortal.sprite == mainPortalOpen) {
			continue12th.SetActive (true);
		}

	}

	public void ResetAll(){
		blackHole.transform.localScale = new Vector3 (0.4f, 0.4f, 0.0f);
		blackHoleWaves.SetActive (true);
		blackHoleWaves2.SetActive (true);
		blackHole.SetActive (false);
		playerParent.SetActive (false);
		playerResetter.SetActive (false);
		playerResetter2.SetActive (false);
		clockWise.SetActive (false);
		antiClockWise.SetActive (false);
		text.SetActive (false);
		text_.SetActive (false);
		text__.SetActive (false);
		text2.SetActive (false);
		text3.SetActive (false);
		text4.SetActive (false);
		text4_.SetActive (false);
		text4__.SetActive (false);
		text5.SetActive (false);
		text6.SetActive (false);
		text6_.SetActive (false);
		text7.SetActive (false);
		text7_.SetActive (false);
		text8.SetActive (false);
		text8_.SetActive (false);
		text9.SetActive (false);
		text9_.SetActive (false);
		text10.SetActive (false);
		text10_.SetActive (false);
		text11.SetActive (false);
		text11_.SetActive (false);
		text11__.SetActive (false);
		text12.SetActive (false);
		text12_.SetActive (false);
		text12__.SetActive (false);
		text13.SetActive (false);
		text14.SetActive (false);
		continueFirst.SetActive (false);
		continueSec.SetActive (false);
		continueThird.SetActive (false);
		continueForth.SetActive (false);
		continuesixth.SetActive (false);
		continueSeventh.SetActive (false);
		continue8th.SetActive (false);
		continue9th.SetActive (false);
		continue10th.SetActive (false);
		continue11th.SetActive (false);
		continue12th.SetActive (false);
		if (boost != null)
			boost.SetActive (false);
		if (harm != null)
			harm.SetActive (false);
		if (dou != null)
			dou.SetActive (false);
		if (flash != null)
			flash.SetActive (false);
		if (slug != null)
			slug.SetActive (false);
		myInstantiate.SetActive (false);
		if (giant != null)
			giant.SetActive (false);
		if (atom != null)
			atom.SetActive (false);
		if (poision != null)
			poision.SetActive (false);
		if (keyPortal != null)
			keyPortal.SetActive (false);
		if (myInstatiateInstance != null)
			Destroy (myInstatiateInstance);
		ChangePortalToOpened ();
	}
	public void SetFirsActive(){
		ResetAll ();
		text.SetActive (true);
		text_.SetActive (true);
		text__.SetActive (true);
		blackHole.SetActive (true);
		myInstantiate.SetActive (true);
	}
	public void SetSectActive(){
		DestroyAll ();
		ResetAll ();
		text2.SetActive (true);
		clockWise.SetActive (true);
		antiClockWise.SetActive (true);
		playerParent.SetActive (true);
		playerResetter.SetActive (true);
		playerResetter2.SetActive (true);
	}
	public void SetThirdtActive(){
		ResetAll ();
		text3.SetActive (true);
		boost.SetActive (true);
		clockWise.SetActive (true);
		antiClockWise.SetActive (true);
		playerParent.SetActive (true);
		blackHole.SetActive (true);
		blackHoleWaves.SetActive (false);
		blackHoleWaves2.SetActive (false);
		playerResetter.SetActive (true);
		playerResetter2.SetActive (true);
	}
	public void SetFourthtActive(){
		ResetAll ();
		text4.SetActive (true);
		text4_.SetActive (true);
		harm.SetActive (true);
		clockWise.SetActive (true);
		antiClockWise.SetActive (true);
		playerParent.SetActive (true);
		blackHole.SetActive (true);
		blackHoleWaves.SetActive (false);
		blackHoleWaves2.SetActive (false);
		playerResetter.SetActive (true);
		playerResetter2.SetActive (true);
	}
	public void SetFifthtActive(){
		ResetAll ();
		text5.SetActive (true);
		dou.SetActive (true);
		playerParent.SetActive (true);
		clockWise.SetActive (true);
		antiClockWise.SetActive (true);
		blackHole.SetActive (true);
		blackHoleWaves.SetActive (false);
		blackHoleWaves2.SetActive (false);
		playerResetter.SetActive (true);
		playerResetter2.SetActive (true);
	}
	public void SetSixthtActive(){
		DestroyExtraPlayers ();
		ResetAll ();
		text6.SetActive (true);
		text6_.SetActive (true);
		flash.SetActive (true);
		clockWise.SetActive (true);
		antiClockWise.SetActive (true);
		playerParent.SetActive (true);
		blackHole.SetActive (true);
		blackHoleWaves.SetActive (false);
		blackHoleWaves2.SetActive (false);
		playerResetter.SetActive (true);
		playerResetter2.SetActive (true);
	}
	public void SetSeventhActive(){
		ResetAll ();
		text7.SetActive (true);
		text7_.SetActive (true);
		slug.SetActive (true);
		clockWise.SetActive (true);
		antiClockWise.SetActive (true);
		playerParent.SetActive (true);
		blackHole.SetActive (true);
		blackHoleWaves.SetActive (false);
		blackHoleWaves2.SetActive (false);
		playerResetter.SetActive (true);
		playerResetter2.SetActive (true);
	}
	public void Set8thActive(){
		ResetAll ();
		text8.SetActive (true);
		text8_.SetActive (true);
		poision.SetActive (true);
		clockWise.SetActive (true);
		antiClockWise.SetActive (true);
		playerParent.SetActive (true);
		blackHole.SetActive (true);
		blackHoleWaves.SetActive (false);
		blackHoleWaves2.SetActive (false);
		playerResetter.SetActive (true);
		playerResetter2.SetActive (true);
	}
	public void Set9thActive(){
		ResetAll ();
		text9.SetActive (true);
		text9_.SetActive (true);
		giant.SetActive (true);
		clockWise.SetActive (true);
		antiClockWise.SetActive (true);
		playerParent.SetActive (true);
		blackHole.SetActive (true);
		blackHoleWaves.SetActive (false);
		blackHoleWaves2.SetActive (false);
		playerResetter.SetActive (true);
		playerResetter2.SetActive (true);
	}
	public void Set10thActive(){
		ResetAll ();
		text10.SetActive (true);
		text10_.SetActive (true);
		atom.SetActive (true);
		clockWise.SetActive (true);
		antiClockWise.SetActive (true);
		playerParent.SetActive (true);
		blackHole.SetActive (true);
		blackHoleWaves.SetActive (false);
		blackHoleWaves2.SetActive (false);
		playerResetter.SetActive (true);
		playerResetter2.SetActive (true);
	}
	public void Set11thActive(){
		ResetAll ();
		text11.SetActive (true);
		text11_.SetActive (true);
		text11__.SetActive (true);
	}
	public void Set12thActive(){
		ResetAll ();
		ChangePortalToClosed ();
		keyPortal.SetActive (true);
		blackHole.SetActive (true);
		myInstantiate.SetActive (true);
		myInstatiateInstance= Instantiate (myInstantiate, myInstantiate.transform.position, Quaternion.identity) as GameObject;
		text12.SetActive (true);
		text12_.SetActive (true);
		text12__.SetActive (true);
	}
	public void Set13thActive(){
		ResetAll ();
		DestroyAll ();
		text13.SetActive (true);
	}
	public void Set14thActive(){
		ResetAll ();
		text14.SetActive (true);
	}
	public void ChangePortal(){
		if (mainPortal.sprite == mainPortalOpen) {
			ChangePortalToClosed ();
		} else {
			ChangePortalToOpened ();
		}
	}
	void ChangePortalToClosed(){
		mainPortal.sprite = mainPortalClosed;
		upperPortal.sprite = upperandbelowClosed;
		belowPortal.sprite = upperandbelowClosed;
		text11_.GetComponent<Text> ().text = "This is CLOSED Portal";
		text11_.GetComponent<Text> ().color = Color.red;
		text11__.GetComponent<Text> ().text = ">>For OPENED portal";
		text11__.GetComponent<Text> ().color = Color.cyan;
	}
	void ChangePortalToOpened(){
		mainPortal.sprite = mainPortalOpen;
		upperPortal.sprite = upperandbelowOpen;
		belowPortal.sprite = upperandbelowOpen;
		text11_.GetComponent<Text> ().text = "This is OPENED Portal";
		text11_.GetComponent<Text> ().color = Color.cyan;
		text11__.GetComponent<Text> ().text = ">>For CLOSED portal";
		text11__.GetComponent<Text> ().color = Color.red;
	}
	void DestroyAll(){
		DestroyBoost ();
		DestroyHarm ();
		DestroyDuo ();
		DestroyGiant ();
		DestroyAtom ();
		DestroyPoision ();
		DestroySlug ();
		DestroyFlash ();
	}
	void DestroyBoost(){
		GameObject[] boosts = GameObject.FindGameObjectsWithTag ("boost");
		foreach (GameObject boost in boosts) {
			Destroy (boost);
		}
	}
	void DestroyHarm(){
		GameObject[] Harms = GameObject.FindGameObjectsWithTag ("harm");
		foreach (GameObject harm in Harms) {
			Destroy (harm);
		}
	}
	void DestroyDuo(){
		GameObject[] Duos = GameObject.FindGameObjectsWithTag ("double");
		foreach (GameObject duo in Duos) {
			Destroy (duo);
		}
	}
	void DestroyGiant(){
		GameObject[] Giants = GameObject.FindGameObjectsWithTag ("GiantPhase");
		foreach (GameObject giant in Giants) {
			Destroy (giant);
		}
	}
	void DestroyAtom(){
		GameObject[] Atoms = GameObject.FindGameObjectsWithTag ("AtomPhase");
		foreach (GameObject atom in Atoms) {
			Destroy (atom);
		}
	}
	void DestroyPoision(){
		GameObject[] Poisons = GameObject.FindGameObjectsWithTag ("Poison");
		foreach (GameObject Poison in Poisons) {
			Destroy (Poison);
		}
	}
	void DestroySlug(){
		GameObject[] Slugs = GameObject.FindGameObjectsWithTag ("Slug");
		foreach (GameObject slug in Slugs) {
			Destroy (slug);
		}
	}
	void DestroyFlash(){
		GameObject[] Flashes = GameObject.FindGameObjectsWithTag ("Flash");
		foreach (GameObject flash in Flashes) {
			Destroy (flash);
		}
	}
	void DestroyExtraPlayers(){
		GameObject[] players = GameObject.FindGameObjectsWithTag ("Player");
		foreach (GameObject player_ in players) {
			if (player != player_)
				Destroy (player_);	
		}
	}
}

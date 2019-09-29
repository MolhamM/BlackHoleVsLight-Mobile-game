using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyToPortal : MonoBehaviour {
	public SpriteRenderer mainPortal;
	public SpriteRenderer upperPortal;
	public SpriteRenderer belowPortal;
	public Sprite mainPortalOpen;
	public Sprite mainPortalClosed;
	public Sprite upperandbelowOpen;
	public Sprite upperandbelowClosed;
	public Transform blackhole;
	public float setScaleOfKeyPortal;
	public AudioClip openedportal;
	void Start () {
		this.transform.localScale = new Vector3 (setScaleOfKeyPortal, setScaleOfKeyPortal, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (blackhole.localScale.x >= this.transform.localScale.x-0.1) {
			OpenPortal ();
			DestroyMe ();
		}
	}
	public void OpenPortal(){
		mainPortal.sprite = mainPortalOpen;
		upperPortal.sprite = upperandbelowOpen;
		belowPortal.sprite = upperandbelowOpen;
		AudioSource.PlayClipAtPoint (openedportal, blackhole.transform.position);
	}
	public void DestroyMe(){
		Destroy (this.gameObject);
	}
}

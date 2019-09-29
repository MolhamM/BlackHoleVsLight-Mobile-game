using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject plasma;

    // Update is called once per frame
    void Update()
    {
		if (CheckPlasma ()) {
			CheckScale ();
			CheckTransform ();
			ChangeColor ();
		}
       
    }
	void ChangeColor(){
		if(plasma.GetComponent<plazmaBall>().getPoison())
			this.GetComponent<ParticleSystem>().startColor = Color.green;
		else
			this.GetComponent<ParticleSystem>().startColor = Color.white;
	}
	void CheckTransform(){
		
			this.transform.localPosition = plasma.transform.position;
	}
	void CheckScale(){
		if (this.gameObject.name == "Visible")
			this.transform.localScale = plasma.transform.localScale+ new Vector3 (0.17f, 0.17f, 0.17f);
		else
			this.transform.localScale = plasma.transform.localScale-new Vector3 (0.1f, 0.1f, 0.1f);
	}
	bool CheckPlasma(){
		if (plasma == null) {
			Destroy (gameObject);
			return false;
		}
		return true;
	}
}

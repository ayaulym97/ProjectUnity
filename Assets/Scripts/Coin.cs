using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
	public PlayerMover pm;
	void onTriggerEnter(Collider col){
		print ("Entered");
		pm.coin++;
		//Destroy(this.gameObject);

		if (col.gameObject.CompareTag ("Coin")) {
			col.gameObject.SetActive (false);
		}


	}
}

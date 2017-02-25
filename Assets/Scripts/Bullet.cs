using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	void OnCollisionEnter(Collision collison){

		GameObject hit = collison.gameObject;
		Health health = hit.GetComponent<Health> ();
		if (health != null) {
			health.TakeDamage (10);
		}
		Destroy (gameObject);
	}

}

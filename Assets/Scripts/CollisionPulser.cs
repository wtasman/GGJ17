﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPulser : MonoBehaviour {
	public GameObject soundPulser;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision other){
		GameObject lastPulse = (GameObject)Instantiate (soundPulser, other.contacts [0].point, transform.rotation);
		lastPulse.GetComponent<SoundPulseCheap> ().lifeSpan = GetComponent<Rigidbody> ().velocity.magnitude;
	}
}

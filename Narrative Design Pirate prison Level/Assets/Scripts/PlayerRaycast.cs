﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour {

	//int layer_mask = LayerMask.GetMask("Interactable");
	//public LayerMask interactableObjects;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;

		float distanceOfRay = 100f;

		Vector3 forward = transform.TransformDirection (Vector3.forward) * 10;


		Debug.DrawRay (transform.position, forward, Color.green);



		if (Physics.Raycast(transform.position,(forward), out hit, LayerMask.NameToLayer("Intractable")))
		{
			distanceOfRay = hit.distance;
			//print (distanceOfRay + "" + hit.collider.gameObject.name);
			if (hit.collider.tag == "Metal") {
				Debug.Log (distanceOfRay + "" + hit.collider.gameObject.name);
			}

		}
			
}
}

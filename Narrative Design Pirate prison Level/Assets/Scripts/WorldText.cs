using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldText : MonoBehaviour {

    public GameObject pickUpObjectsText;

	// Use this for initialization
	void Start () {
        pickUpObjectsText.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

     void OnTriggerEnter(Collider other)
    {
        pickUpObjectsText.SetActive(true);
    }

     void OnTriggerExit(Collider other)
    {
        pickUpObjectsText.SetActive(false);
        Destroy(this.gameObject);
    }
}

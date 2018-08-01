using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenWall : MonoBehaviour {

    public GameObject brokenWallTrigger;
    public GameObject dialogueTriggerSecond;
    public GameObject brokenWindowWall;
    public GameObject brokenWallGuard;
    public GameObject currentWindowWall;
    public GameObject currentGuardWall;
    public GameObject currentGate1;
    public GameObject currentGate2;

    public CameraShake cameraShake;
   

	// Use this for initialization
	void Start () {
        brokenWallTrigger.SetActive(false);
        dialogueTriggerSecond.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindGameObjectWithTag("Metal") == null)
        {
            brokenWallTrigger.SetActive(true);
        }
	}

     void OnTriggerEnter(Collider other)
    {
           StartCoroutine(cameraShake.Shake(.15f, .4f));
        if (GameObject.FindGameObjectWithTag("Metal") == null)
        {
            brokenWindowWall.SetActive(true);
            brokenWallGuard.SetActive(true);
            currentWindowWall.SetActive(false);
            currentGuardWall.SetActive(false);
            currentGate1.SetActive(false);
            currentGate2.SetActive(false);
            dialogueTriggerSecond.SetActive(true);

            brokenWallTrigger.SetActive(true);
        }
    }
}

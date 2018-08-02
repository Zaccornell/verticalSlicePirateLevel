using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenWall : MonoBehaviour {

    
    public GameObject dialogueTriggerSecond;
    public GameObject brokenWindowWall;
    public GameObject brokenWallGuard;
    public GameObject currentWindowWall;
    public GameObject currentGuardWall;
    public GameObject currentGate1;
    public GameObject currentGate2;
    public GameObject woodbreaking1;
    public GameObject woodbreaking2;
    public GameObject cannonFire1;
    public GameObject textBoxOutside;
    public GameObject textBoxInside;
    public GameObject button;
    public GameObject nameText;
    public GameObject dialogueText;
    public GameObject brokenGate1;
    public GameObject brokenGate2;

    float timer;

    

    public CameraShake cameraShake;
   

	// Use this for initialization
	void Start () {
       
        dialogueTriggerSecond.SetActive(false);
        woodbreaking1.SetActive(false);
        woodbreaking2.SetActive(false);
        cannonFire1.SetActive(false);
        brokenGate1.SetActive(false);
        brokenGate2.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindGameObjectWithTag("Metal") == null)
        {
           
        }
        timer = Time.time;
	}

     void OnTriggerEnter(Collider other)
    {
           StartCoroutine(cameraShake.Shake(.15f, .4f));
        if (GameObject.FindGameObjectWithTag("Metal") == null)
        {
            textBoxInside.SetActive(true);
            textBoxOutside.SetActive(true);
            Debug.Log("it worked");
            brokenWindowWall.SetActive(true);
            brokenWallGuard.SetActive(true);
            currentWindowWall.SetActive(false);
            currentGuardWall.SetActive(false);
            currentGate1.SetActive(false);
            currentGate2.SetActive(false);
            dialogueTriggerSecond.SetActive(true);
            button.SetActive(true);
            nameText.SetActive(true);
            dialogueText.SetActive(true);
            brokenGate1.SetActive(true);
            brokenGate2.SetActive(true);

            if (other.tag == "player")
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }

            woodbreaking1.SetActive(true);
                woodbreaking2.SetActive(true);
            
            cannonFire1.SetActive(true);

            
        }
    }

     void OnTriggerExit(Collider other)
    {
        textBoxInside.SetActive(false);
        textBoxOutside.SetActive(false);
        button.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        nameText.SetActive(false);
        dialogueText.SetActive(false);

        //GameObject camera = GameObject.Find("Camera");
        //camera.GetComponent<playerLook>().EndTalking();
    }

    void HidingCursor()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}

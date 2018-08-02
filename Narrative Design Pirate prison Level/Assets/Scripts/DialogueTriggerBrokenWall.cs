using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerBrokenWall : MonoBehaviour {

    public Dialogue dialogue;
    public GameObject textBoxOutside;
    public GameObject textBoxInside;
    public GameObject button;
    public GameObject nameText;
    public GameObject dialogueText;
   

    public Cursor cursorUI;

    private void Start()
    {
        textBoxOutside.SetActive(false);
        textBoxInside.SetActive(false);
        button.SetActive(false);
        

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Metal") == null)
        {
            Debug.Log("it worked");
           
            //Destroy(this.gameObject);
            
        }
    }
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            TriggerDialogue();
            textBoxOutside.SetActive(true);
            textBoxInside.SetActive(true);
            button.SetActive(true);
            nameText.SetActive(true);
            dialogueText.SetActive(true);

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


            //FindObjectOfType<DialogueManager>().DisplayNextSentance();

        }
        GameObject camera = GameObject.Find("Camera");

        camera.GetComponent<playerLook>().Talking();

    }

    public void OnTriggerExit(Collider other)
    {
        textBoxOutside.SetActive(false);
        textBoxInside.SetActive(false);
        button.SetActive(false);
        nameText.SetActive(false);
        dialogueText.SetActive(false);
        //if (GameObject.FindGameObjectWithTag("Metal") == null)
        //{
        //    Debug.Log("it worked");
        //    triggerForBrokenWallTrigger.SetActive(true);
        //    Destroy(this.gameObject);
        //}

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        GameObject camera = GameObject.Find("Camera");
        camera.GetComponent<playerLook>().EndTalking();
    }

    void HidingCursor()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}

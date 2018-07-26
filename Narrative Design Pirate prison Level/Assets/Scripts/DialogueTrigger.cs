using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour {

    public Dialogue dialogue;
    public GameObject textBox;
    public GameObject button;
    public GameObject nameText;
    public GameObject dialogueText;
    public GameObject triggerForBrokenWallTrigger;

    public Cursor cursorUI;

    private void Start()
    {
        textBox.SetActive(false);
        button.SetActive(false);
        triggerForBrokenWallTrigger.SetActive(false);

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }


     void Update()
    {
        
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
            textBox.SetActive(true);
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
        Debug.Log("This worked");

    }

    public void OnTriggerExit(Collider other)
    {
        textBox.SetActive(false);
        button.SetActive(false);
        nameText.SetActive(false);
        dialogueText.SetActive(false);
        Destroy(this.gameObject);
        triggerForBrokenWallTrigger.SetActive(true);

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

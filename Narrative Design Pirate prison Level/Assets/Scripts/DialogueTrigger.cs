using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

    public Dialogue dialogue;
    public GameObject textBox;
    public GameObject button;
    public GameObject nameText;
    public GameObject dialogueText;
    public GameObject triggerForBrokenWallTrigger;

    private void Start()
    {
        textBox.SetActive(false);
        button.SetActive(false);
        triggerForBrokenWallTrigger.SetActive(false);
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
            
           

            //FindObjectOfType<DialogueManager>().DisplayNextSentance();

        }
      

    }

    public void OnTriggerExit(Collider other)
    {
        textBox.SetActive(false);
        button.SetActive(false);
        nameText.SetActive(false);
        dialogueText.SetActive(false);
        Destroy(this.gameObject);
        triggerForBrokenWallTrigger.SetActive(true);
       
    }

    void HidingCursor()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}

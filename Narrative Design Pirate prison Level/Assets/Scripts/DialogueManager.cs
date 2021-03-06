﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {


    public Text nameText;
    public Text dialogueText;
    public GameObject textBoxOutside;
    public GameObject textBoxInside;
    public GameObject button;
    new bool name = false;
   

    public Queue<string> sentances;

	// Use this for initialization
	void Start () {
        sentances = new Queue<string>();
	}
	

    public void StartDialogue(Dialogue dialogue)
    {
        nameText.text = dialogue.name;

        sentances.Clear();

        foreach (string sentance in dialogue.sentances)
        {
            sentances.Enqueue(sentance);
        }

        DisplayNextSentance();
    }

    public void DisplayNextSentance()
    {
            if (sentances.Count == 0)
            {
                EndDialogue();
                return;
            }


            string sentance = sentances.Dequeue();
        dialogueText.text = sentance;
        
    }

    public void EndDialogue()
    {
        textBoxInside.SetActive(false);
        textBoxOutside.SetActive(false);
        button.SetActive(false);
        dialogueText.text = "";
        nameText.text = "";
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnded : MonoBehaviour {

    public GameObject youWin;

	// Use this for initialization
	void Start () {
        youWin.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0f;
        youWin.SetActive(true);

        if (other.tag == "Player")
        {
            Application.Quit();
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour {

    public Camera playerCamera;
    public float maxZoom;
    public float zoomSpeed;

    float defaultZoom;
    float targetZoom;

	// Use this for initialization
	void Start () {
        defaultZoom = playerCamera.fieldOfView;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(1))
        {
            targetZoom = maxZoom;
        }
        else
        {
            targetZoom = defaultZoom;
        }


        playerCamera.fieldOfView = Mathf.Lerp(playerCamera.fieldOfView, targetZoom, Time.deltaTime * zoomSpeed);
	}
}

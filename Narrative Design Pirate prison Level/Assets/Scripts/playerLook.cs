using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLook : MonoBehaviour {

    public Transform playerBody;
    public float mouseSensitivity;

    float xAxisClamp = 0.0f;

    void Awake()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update () {
        RotateCamera();

        //Cursor.lockState = CursorLockMode.Locked;
    }

    void RotateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        float rotateAmountX = mouseX * mouseSensitivity;
        float rotateAmountY = mouseY * mouseSensitivity;

        xAxisClamp -= rotateAmountY;

        Vector3 targetRotCam = transform.rotation.eulerAngles;
        Vector3 targetRotBody = playerBody.rotation.eulerAngles;

        targetRotCam.x -= rotateAmountY;
        targetRotCam.z = 0;
        targetRotBody.y += rotateAmountX;

        if(xAxisClamp > 90)
        {
            xAxisClamp = 90;
            targetRotCam.x = 90;
        }
        else if (xAxisClamp < -90)
        {
            xAxisClamp = -90;
            targetRotCam.x = 270;
        }
        



        transform.rotation = Quaternion.Euler(targetRotCam);
        playerBody.rotation = Quaternion.Euler(targetRotBody);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    CharacterController charControl;
    public float walkSpeed;

     void Awake()
    {
        charControl = GetComponent<CharacterController>();
    }

     void Update()
    {
        MovePlayer();

        //if (Input.GetKey(KeyCode.Space))
        //{
        //    transform.position = transform.position + new Vector3(0, 0.3f, 0);
        //}
    }

    void MovePlayer()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        Vector3 moveDirSide = transform.right * horiz * walkSpeed;
        Vector3 moveDirForward = transform.forward * vert * walkSpeed;

        charControl.SimpleMove(moveDirSide);
        charControl.SimpleMove(moveDirForward);
    }
}

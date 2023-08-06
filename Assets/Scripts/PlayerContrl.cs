using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContrl : MonoBehaviour
{
    private float speed;
    public float jumpSpeed = 7.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;
    
    void Start()
    {
         speed = 10f;
         controller = GetComponent<CharacterController>();
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 20f;
        }
        else
        {
            speed = 7f;
        }
        playermove();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

    }


    void playermove()
    {
        TurnTo(Camera.main.transform.forward);
    }

    void TurnTo(Vector3 direction)
    {
        Quaternion q = Quaternion.identity;
        q.SetLookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, q.eulerAngles.y, 0), Time.deltaTime * 40);
    }



}

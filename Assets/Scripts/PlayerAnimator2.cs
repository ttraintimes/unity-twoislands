using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator2: MonoBehaviour {

    private Animator PlayerAni;
    private AudioSource ads;
    private AudioSource ads2;
    public AudioClip[] jumpland;

    private void Start() {
        ads = GetComponent < AudioSource > ();
        ads2 = transform.parent.GetChild(1).GetComponent < AudioSource > ();

    }
    void Update() {
        PlayerAni = GetComponent < Animator > ();
        playermove();

    }


    void playermove() {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) {
            PlayerAni.SetBool("run", true);
            ads.enabled = true;
        } else {
            PlayerAni.SetBool("run", false);
            ads.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            PlayerAni.SetBool("jump", true);
            ads2.PlayOneShot(jumpland[0]);
            isJump = true;
        } else{
            if(isJump){
            isJump =false;
            PlayerAni.SetBool("jump", false);
           Invoke("land",2f);
            }      
        }
    }
    private bool isJump = false;
    public void land(){
        ads2.PlayOneShot(jumpland[1]);
    }
}
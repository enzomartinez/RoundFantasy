﻿using UnityEngine;
using System.Collections;

public class Atack_Left : MonoBehaviour {

    Animator animator;

    const int Entry = 0;
    const int PlayerAtackLeft = 1;
    const int PlayerStand = 2;

    int _currentAnimationState = Entry;

    void Start(){
        animator = this.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeState(PlayerAtackLeft);
            
        }
        if (Input.GetMouseButtonDown(1))
        {
            ChangeState(PlayerStand);
        }
	}

    void ChangeState(int AtackLeft)
    {
        if (_currentAnimationState == AtackLeft)
            return;

        switch (AtackLeft)
        {

            case PlayerAtackLeft:
                animator.SetInteger("AtackLeft", PlayerAtackLeft);
                break;

            case PlayerStand:
                animator.SetInteger("AtackLeft", PlayerStand);
                break;
        }
    }

}

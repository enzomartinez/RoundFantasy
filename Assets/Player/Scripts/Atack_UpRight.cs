using UnityEngine;
using System.Collections;

public class Atack_UpRight : MonoBehaviour {

    Animator animator;

    const int Entry = 0;
    const int PlayerAtackUpRight = 1;
    const int PlayerStand = 2;

    int _currentAnimationState = Entry;

    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeState(PlayerAtackUpRight);

        }
        if (Input.GetMouseButtonDown(1))
        {
            ChangeState(PlayerStand);
        }
    }

    void ChangeState(int AtackUpRight)
    {
        if (_currentAnimationState == AtackUpRight)
            return;

        switch (AtackUpRight)
        {

            case PlayerAtackUpRight:
                animator.SetInteger("AtackUpRight", PlayerAtackUpRight);
                break;

            case PlayerStand:
                animator.SetInteger("AtackUpRight", PlayerStand);
                break;
        }
    }
}

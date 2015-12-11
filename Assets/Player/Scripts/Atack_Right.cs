using UnityEngine;
using System.Collections;

public class Atack_Right : MonoBehaviour {

    Animator animator;

    const int Entry = 0;
    const int PlayerAtackRight= 1;
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
            ChangeState(PlayerAtackRight);

        }
        if (Input.GetMouseButtonDown(1))
        {
            ChangeState(PlayerStand);
        }
    }

    void ChangeState(int AtackRight)
    {
        if (_currentAnimationState == AtackRight)
            return;

        switch (AtackRight)
        {

            case PlayerAtackRight:
                animator.SetInteger("AtackRight", PlayerAtackRight);
                break;

            case PlayerStand:
                animator.SetInteger("AtackRight", PlayerStand);
                break;
        }
    }
}

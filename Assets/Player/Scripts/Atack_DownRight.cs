using UnityEngine;
using System.Collections;

public class Atack_DownRight : MonoBehaviour {

    Animator animator;

    const int Entry = 0;
    const int PlayerAtackDownRight = 1;
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
            ChangeState(PlayerAtackDownRight);

        }
        if (Input.GetMouseButtonDown(1))
        {
            ChangeState(PlayerStand);
        }
    }

    void ChangeState(int AtackDownRight)
    {
        if (_currentAnimationState == AtackDownRight)
            return;

        switch (AtackDownRight)
        {

            case PlayerAtackDownRight:
                animator.SetInteger("AtackDownRight", PlayerAtackDownRight);
                break;

            case PlayerStand:
                animator.SetInteger("AtackDownRight", PlayerStand);
                break;
        }
    }
}

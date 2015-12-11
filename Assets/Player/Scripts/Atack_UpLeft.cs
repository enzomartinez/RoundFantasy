using UnityEngine;
using System.Collections;

public class Atack_UpLeft : MonoBehaviour {

    Animator animator;

    const int Entry = 0;
    const int PlayerAtackUpLeft = 1;
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
            ChangeState(PlayerAtackUpLeft);

        }
        if (Input.GetMouseButtonDown(1))
        {
            ChangeState(PlayerStand);
        }
    }

    void ChangeState(int AtackUpLeft)
    {
        if (_currentAnimationState == AtackUpLeft)
            return;

        switch (AtackUpLeft)
        {

            case PlayerAtackUpLeft:
                animator.SetInteger("AtackUpLeft", PlayerAtackUpLeft);
                break;

            case PlayerStand:
                animator.SetInteger("AtackUpLeft", PlayerStand);
                break;
        }
    }
}

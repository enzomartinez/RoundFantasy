using UnityEngine;
using System.Collections;

public class Atack_Up : MonoBehaviour {

    Animator animator;

    const int Entry = 0;
    const int PlayerAtackUp = 1;
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
            ChangeState(PlayerAtackUp);

        }
        if (Input.GetMouseButtonDown(1))
        {
            ChangeState(PlayerStand);
        }
    }

    void ChangeState(int AtackUp)
    {
        if (_currentAnimationState == AtackUp)
            return;

        switch (AtackUp)
        {

            case PlayerAtackUp:
                animator.SetInteger("AtackUp", PlayerAtackUp);
                break;

            case PlayerStand:
                animator.SetInteger("AtackUp", PlayerStand);
                break;
        }
    }
}

using UnityEngine;
using System.Collections;

public class Atack_DownLeft : MonoBehaviour {

    Animator animator;

    const int Entry = 0;
    const int PlayerAtackDownLeft = 1;
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
            ChangeState(PlayerAtackDownLeft);

        }
        if (Input.GetMouseButtonDown(1))
        {
            ChangeState(PlayerStand);
        }
    }

    void ChangeState(int AtackDownLeft)
    {
        if (_currentAnimationState == AtackDownLeft)
            return;

        switch (AtackDownLeft)
        {

            case PlayerAtackDownLeft:
                animator.SetInteger("AtackDownLeft", PlayerAtackDownLeft);
                break;

            case PlayerStand:
                animator.SetInteger("AtackDownLeft", PlayerStand);
                break;
        }
    }
}

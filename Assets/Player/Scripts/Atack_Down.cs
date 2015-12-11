using UnityEngine;
using System.Collections;

public class Atack_Down : MonoBehaviour {

    Animator animator;

    const int Entry = 0;
    const int PlayerAtackdown = 1;
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
            ChangeState(PlayerAtackdown);

        }
        if (Input.GetMouseButtonDown(1))
        {
            ChangeState(PlayerStand);
        }
    }

    void ChangeState(int AtackDown)
    {
        if (_currentAnimationState == AtackDown)
            return;

        switch (AtackDown)
        {

            case PlayerAtackdown:
                animator.SetInteger("AtackDown", PlayerAtackdown);
                break;

            case PlayerStand:
                animator.SetInteger("AtackDown", PlayerStand);
                break;
        }
    }
}

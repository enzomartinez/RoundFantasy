using UnityEngine;
using System.Collections;

public class ChangeSprite : MonoBehaviour
{

    //Public Vars
    public Quaternion rotation;
    public Vector3 angulo;

    //Private Vars
    private Vector3 mousePosition;
    private Vector3 direction;

    Animator animator;

    const int Entry = 0;
    const int Player_Down = 1;
    const int Player_Up = 2;
    const int Player_UpRight = 3;
    const int Player_Right = 4;
    const int Player_DownRight = 5;
    const int Player_DownLeft = 6;
    const int Player_Left = 7;
    const int Player_UpLeft = 8;

    int _currentAnimationState = Entry;


    void Start()
    {
        animator = this.GetComponent<Animator>();
    }


    void Update()
    {

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);

        rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
        angulo = rotation.eulerAngles;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeState(Player_Down);
        }
        else if (angulo.z > 158 && angulo.z < 202)
        {
            ChangeState(Player_Down);

        }
        else if (angulo.z > 344 || angulo.z < 22)
        {
            ChangeState(Player_Up);
        }
        else if (angulo.z > 248 && angulo.z < 292)
        {
            ChangeState(Player_Right);
        }
        else if (angulo.z > 68 && angulo.z < 112)
        {
            ChangeState(Player_Left);
        }
        else if (angulo.z > 22 && angulo.z < 68)
        {
            ChangeState(Player_UpLeft);
        }
        else if (angulo.z > 122 && angulo.z < 158)
        {
            ChangeState(Player_DownLeft);
        }
        else if (angulo.z > 202 && angulo.z < 248)
        {
            ChangeState(Player_DownRight);
        }
        else if (angulo.z > 292 && angulo.z < 344)
        {
            ChangeState(Player_UpRight);
        }
    }

    void ChangeState(int ChangeSprite)
    {
        if (_currentAnimationState == ChangeSprite)
            return;

        switch (ChangeSprite)
        {

            case Player_Down:
                animator.SetInteger("ChangeSprite", Player_Down);
                break;
            case Player_Up:
                animator.SetInteger("ChangeSprite", Player_Up);
                break;
            case Player_UpRight:
                animator.SetInteger("ChangeSprite", Player_UpRight);
                break;
            case Player_DownRight:
                animator.SetInteger("ChangeSprite", Player_DownRight);
                break;
            case Player_Left:
                animator.SetInteger("ChangeSprite", Player_Left);
                break;
            case Player_Right:
                animator.SetInteger("ChangeSprite", Player_Right);
                break;
            case Player_UpLeft:
                animator.SetInteger("ChangeSprite", Player_UpLeft);
                break;
            case Player_DownLeft:
                animator.SetInteger("ChangeSprite", Player_DownLeft);
                break;
        }

    }
}
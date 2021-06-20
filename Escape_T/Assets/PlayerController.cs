using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float move_speed; //ĳ���� �̵��ӵ�
    Animator animator;
    string animationState = "AnimationState";
    enum States
    {
        stop = 2,
        move = 1,
        move2 = 3
    }
    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0 || Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * move_speed * Time.deltaTime, 0f, 0f));
            animator.SetInteger(animationState, (int)States.move);
        }

        if (Input.GetAxisRaw("Vertical") > 0 || Input.GetAxisRaw("Vertical") < 0)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * move_speed * Time.deltaTime, 0f));
            animator.SetInteger(animationState, (int)States.move2);
        }
        else
        {
            animator.SetInteger(animationState, (int)States.stop);

            // �÷��̾� �ӵ��� ���� �ִϸ��̼� �ӵ� ����
            this.animator.speed = move_speed / 2.0f;
        }
    }
}

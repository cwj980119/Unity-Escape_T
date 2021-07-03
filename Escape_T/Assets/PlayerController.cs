using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float move_speed;//캐릭터 이동속도
    Vector2 movement = new Vector2();
    Animator animator;
    Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement.Normalize();

        rigidbody2D.velocity = movement * move_speed;

        if (Mathf.Approximately(movement.x, 0) && Mathf.Approximately(movement.y, 0))
        {
            animator.SetBool("isMove", false);
        }

        else
        {
            animator.SetBool("isMove", true);
        }

        animator.SetFloat("xDir", movement.x);
        animator.SetFloat("yDir", movement.y);


        // 플레이어 속도에 따라서 애니메이션 속도 변경
        this.animator.speed = move_speed / 1.0f;
     
    }
}

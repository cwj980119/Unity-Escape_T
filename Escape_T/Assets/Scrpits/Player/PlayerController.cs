using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    static public PlayerController instance; //ĳ���� �ߺ� ���� ����

    public string currentScene;
    public float move_speed;//ĳ���� �̵��ӵ�
    Vector2 movement = new Vector2();
    Animator animator;
    private Rigidbody2D rigid_body_2d;
    public JoystickController joystick;

    // 예원 걸을 때 소리 삽입 하려고 수정
    [SerializeField]
    AudioController audio_controller;
    // 예원 걸을 때 소리 삽입 하려고 수정

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
            this.animator = GetComponent<Animator>();
            rigid_body_2d = GetComponent<Rigidbody2D>();
            instance = this;
        }
        else {
            Destroy(this.gameObject);
        }

        audio_controller = GameObject.Find("Music").GetComponent<AudioController>();
    }

    public void StopMove(){
        joystick.CancelDrag();
    }

    //player move
    public void Move(Vector2 move){
        movement.x = move.x;
        movement.y = move.y;
        movement.Normalize();

        rigid_body_2d.velocity = movement * move_speed;

        if (Mathf.Approximately(movement.x, 0) && Mathf.Approximately(movement.y, 0))
        {
            animator.SetBool("isMove", false);

            // 예원 걸을 때 소리 삽입 하려고 수정
            audio_controller.EffectSoundOff(0);
            // 예원 걸을 때 소리 삽입 하려고 수정
        }

        else
        {
            animator.SetBool("isMove", true);
            // 예원 걸을 때 소리 삽입 하려고 수정
            if (!audio_controller.Effect[0].isPlaying)
                audio_controller.EffectSoundOn(0);
            // 예원 걸을 때 소리 삽입 하려고 수정
        }

        animator.SetFloat("xDir", movement.x);
        animator.SetFloat("yDir", movement.y);


        // adjust animation speed
        this.animator.speed = move_speed / 1.0f;
    }
    
}

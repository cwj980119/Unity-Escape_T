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
    private Rigidbody2D rigidbody2D;
    public JoystickController joystick;

    // 예원 걸을 때 소리 삽입 하려고 수정
    [SerializeField]
    AudioSource audioSrc;
    // 예원 걸을 때 소리 삽입 하려고 수정

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
            this.animator = GetComponent<Animator>();
            rigidbody2D = GetComponent<Rigidbody2D>();
            instance = this;
        }
        else {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

        // movement.x = Input.GetAxisRaw("Horizontal");
        // Debug.Log(movement.x);
        // movement.y = Input.GetAxisRaw("Vertical");
        // Debug.Log(movement.y);

        // Move(movement);
     
    }

    public void StopMove(){
        joystick.CancelDrag();
    }

    public void Move(Vector2 move){
        movement.x = move.x;
        movement.y = move.y;
        movement.Normalize();

        rigidbody2D.velocity = movement * move_speed;

        if (Mathf.Approximately(movement.x, 0) && Mathf.Approximately(movement.y, 0))
        {
            animator.SetBool("isMove", false);

            // 예원 걸을 때 소리 삽입 하려고 수정
            audioSrc.Stop();
            // 예원 걸을 때 소리 삽입 하려고 수정
        }

        else
        {
            animator.SetBool("isMove", true);
            // 예원 걸을 때 소리 삽입 하려고 수정
            if (!audioSrc.isPlaying)
                audioSrc.Play();
            // 예원 걸을 때 소리 삽입 하려고 수정
        }

        animator.SetFloat("xDir", movement.x);
        animator.SetFloat("yDir", movement.y);


        // �÷��̾� �ӵ��� ���� �ִϸ��̼� �ӵ� ����
        this.animator.speed = move_speed / 1.0f;
    }
    
}

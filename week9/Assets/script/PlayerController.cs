using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //작성한 aniamtion controllor불러옴
    private Animator m_animator;
    private Vector3 m_velocity;

    private bool m_wasGrounded;
    private bool m_isGrounded = true;

    public float m_moveSpeed = 2.0f;
    public float m_jumpForce = 5.0f;

    void Start()
    {
        //시작하면 애니메이터 속성 받아옴
        m_animator = GetComponent<Animator>();
    }

    void Update()
    {
        //현재grounded 스텟
        m_animator.SetBool("Grounded", m_isGrounded);
        PlayerMove();
        JumpingAndLanding();

        //넣어줌
        m_wasGrounded = m_isGrounded;
    }
    private void PlayerMove()
    {
        CharacterController controller = GetComponent<CharacterController>();
        float gravity = 20.0f; //중력부여

        if (controller.isGrounded) //캐릭터 지면여부 계속 검사
        {
            m_velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            //유니티 기본제공 키->변수값 조정 내용 불러옴
            //ex. keyW -> Vertical=(0,0,1)
            m_velocity = m_velocity.normalized;
            //정규화(키 동시 입력시 더 많이 이동하는 내용을 조정(루트2 / 1, 0, r2/1)

            if (Input.GetKey(KeyCode.LeftShift))
            {
                m_velocity *= 2.0f;//뛰기>속도값조정
            }
            m_animator.SetFloat("MoveSpeed", m_velocity.magnitude);
            //m_velocity를 movespeed float에 부여

            if (Input.GetButtonDown("Jump"))
            {
                m_velocity.y = m_jumpForce;
            }
            else if (m_velocity.magnitude > 0.5) 
                //jump아닐때 && 이동값이 미미하게 존재할때(움직이기 시작할때)
            {
                transform.LookAt(transform.position + m_velocity);
                //이동하고자 하는 방향 바라보기
            }
        }
        m_velocity.y -= gravity * Time.deltaTime;
        controller.Move(m_velocity * m_moveSpeed * Time.deltaTime);//월드기준
        m_isGrounded = controller.isGrounded;
    }
    private void JumpingAndLanding()
    {
        if (!m_wasGrounded && m_isGrounded)
        {
            m_animator.SetTrigger("Land");
        }

        if (!m_isGrounded && m_wasGrounded)
        {
            m_animator.SetTrigger("Jump");
        }
    }

}

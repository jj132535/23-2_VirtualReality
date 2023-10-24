using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //�ۼ��� aniamtion controllor�ҷ���
    private Animator m_animator;
    private Vector3 m_velocity;

    private bool m_wasGrounded;
    private bool m_isGrounded = true;

    public float m_moveSpeed = 2.0f;
    public float m_jumpForce = 5.0f;

    void Start()
    {
        //�����ϸ� �ִϸ����� �Ӽ� �޾ƿ�
        m_animator = GetComponent<Animator>();
    }

    void Update()
    {
        //����grounded ����
        m_animator.SetBool("Grounded", m_isGrounded);
        PlayerMove();
        JumpingAndLanding();

        //�־���
        m_wasGrounded = m_isGrounded;
    }
    private void PlayerMove()
    {
        CharacterController controller = GetComponent<CharacterController>();
        float gravity = 20.0f; //�߷ºο�

        if (controller.isGrounded) //ĳ���� ���鿩�� ��� �˻�
        {
            m_velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            //����Ƽ �⺻���� Ű->������ ���� ���� �ҷ���
            //ex. keyW -> Vertical=(0,0,1)
            m_velocity = m_velocity.normalized;
            //����ȭ(Ű ���� �Է½� �� ���� �̵��ϴ� ������ ����(��Ʈ2 / 1, 0, r2/1)

            if (Input.GetKey(KeyCode.LeftShift))
            {
                m_velocity *= 2.0f;//�ٱ�>�ӵ�������
            }
            m_animator.SetFloat("MoveSpeed", m_velocity.magnitude);
            //m_velocity�� movespeed float�� �ο�

            if (Input.GetButtonDown("Jump"))
            {
                m_velocity.y = m_jumpForce;
            }
            else if (m_velocity.magnitude > 0.5) 
                //jump�ƴҶ� && �̵����� �̹��ϰ� �����Ҷ�(�����̱� �����Ҷ�)
            {
                transform.LookAt(transform.position + m_velocity);
                //�̵��ϰ��� �ϴ� ���� �ٶ󺸱�
            }
        }
        m_velocity.y -= gravity * Time.deltaTime;
        controller.Move(m_velocity * m_moveSpeed * Time.deltaTime);//�������
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

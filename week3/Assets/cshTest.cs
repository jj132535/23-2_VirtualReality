using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //================================
        //3���� ���� ����
        //:Generating a 3D vector
        //Vector3 v = new Vector3(1.0f, 2.0f, 3.0f);

        //�� ��ũ��Ʈ�� ���� ��ü(this)�� ��ġ(transform)��
        //://Transform value of this object with this script
        Vector3 v = this.gameObject.transform.position;

        Debug.Log(v);
    }

    // Update is called once per frame
    void Update()
    {
        //================================
        /*
        ������Ʈ�� ���ٰ� �����̽� ������ �������� 1�ʵ��� ��� ���
        ��Input.GetKeyDown <������ �������� �ѹ� ����
        ��Input.GetKeyUp <������ ���� �������� �ѹ�
        ---
        Output for 1 second from the moment you turn to update and press space
        ��InInput.GetKeyDown < Run once only as soon as you press it
        ����InInput.GetKeyUp < Just once when you press and take it off
        */
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("space");
        }
        //================================

        if (Input.GetMouseButton(0 button))
        {
            Debug.Log(Input.mousePosition);
        }
    }
}

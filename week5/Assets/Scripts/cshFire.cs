using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshFire : MonoBehaviour
{
    //�Ѿ� �ӵ� ����
    private float bulletSpeed = 1000.0f;
    private Transform thisTransform;
    // Use this for initialization
    void Start()
    {
        //��ü�� ��ġ�� �ҷ�����
        thisTransform = GetComponent<Transform>();
        //�Լ�����(���۵ɶ� 1ȸ)
        FireBullet();
    }

    void FireBullet()
    {
        //���� ��ü ��ġ���� �������� �Ѿ� �ӵ���ŭ ������ ���� �ش�
        GetComponent<Rigidbody>().AddForce(thisTransform.forward * bulletSpeed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshSpawnBullet : MonoBehaviour
{
    //�Ѿ� ������(����Ƽ�� �ο�����)
    public Transform Bullet;
    //�Ѿ��� �����Ǵ� �ֱ�
    public float fireTime = 1.0f;
    //�������ð�
    public float firePassTime = 0.0f;
    //�Ѿ� ���� ��ġ,������ �����ϱ� ���� ��ġ�� 
    //����Ƽ empobj�� �����ǰ� �ο�
    public Transform BulletFirePos;

    public Transform LookatObj;

    // Update is called once per frame
    void Update()
    {
        //�ֱⰡ �Ǹ�
        if (firePassTime >= fireTime)
        {
            //Instantiate:������ ����(������Ʈ,��ġ��,ȸ���� �޾ƿ�)
            //Bullet ������ �����Ǹ� cshFire.cs��ũ��Ʈ ����->�Ѿ� �̵�
            Instantiate(Bullet, BulletFirePos.position, BulletFirePos.rotation);
            //�ð�����
            firePassTime = 0.0f;
        }
        else
        {
            firePassTime += Time.deltaTime;
        }
        transform.LookAt(LookatObj);
    }
}


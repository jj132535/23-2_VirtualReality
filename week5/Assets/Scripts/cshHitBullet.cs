using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshHitBullet : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // Start is called before the first frame update
    //����Ƽ �������� �� �浹�ɶ� �ݹ�Ǵ� �ż���(�浹����)
    //���浹 ������Ʈ �����Ϳ� �浹 ���� ���� ���� �� ����
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "BULLET")
        {
            Destroy(coll.gameObject);
        }
    }

}

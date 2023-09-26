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
    //유니티 물리엔진 상 충돌될때 콜백되는 매서드(충돌정보)
    //ㄴ충돌 오브젝트 데이터와 충돌 지점 정보 얻을 수 있음
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "BULLET")
        {
            Destroy(coll.gameObject);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshFire : MonoBehaviour
{
    //총알 속도 지정
    private float bulletSpeed = 1000.0f;
    private Transform thisTransform;
    // Use this for initialization
    void Start()
    {
        //객체의 위치값 불러오기
        thisTransform = GetComponent<Transform>();
        //함수실행(시작될때 1회)
        FireBullet();
    }

    void FireBullet()
    {
        //현재 객체 위치에서 앞쪽으로 총알 속도만큼 앞으로 힘을 준다
        GetComponent<Rigidbody>().AddForce(thisTransform.forward * bulletSpeed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshSpawnBullet : MonoBehaviour
{
    //총알 프리팹(유니티로 부여받음)
    public Transform Bullet;
    //총알이 생성되는 주기
    public float fireTime = 1.0f;
    //현재경과시간
    public float firePassTime = 0.0f;
    //총알 생성 위치,방향을 제어하기 위한 위치값 
    //유니티 empobj로 포지션값 부여
    public Transform BulletFirePos;

    public Transform LookatObj;

    // Update is called once per frame
    void Update()
    {
        //주기가 되면
        if (firePassTime >= fireTime)
        {
            //Instantiate:프리팹 생성(오브젝트,위치값,회전값 받아옴)
            //Bullet 프리팹 생성되며 cshFire.cs스크립트 실행->총알 이동
            Instantiate(Bullet, BulletFirePos.position, BulletFirePos.rotation);
            //시간리셋
            firePassTime = 0.0f;
        }
        else
        {
            firePassTime += Time.deltaTime;
        }
        transform.LookAt(LookatObj);
    }
}


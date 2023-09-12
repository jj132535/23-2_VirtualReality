using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //================================
        //3차원 벡터 생성
        //:Generating a 3D vector
        //Vector3 v = new Vector3(1.0f, 2.0f, 3.0f);

        //이 스크립트를 가진 객체(this)의 위치(transform)값
        //://Transform value of this object with this script
        Vector3 v = this.gameObject.transform.position;

        Debug.Log(v);
    }

    // Update is called once per frame
    void Update()
    {
        //================================
        /*
        업데이트로 돌다가 스페이스 누르는 순간부터 1초동안 계속 출력
        ㄴInput.GetKeyDown <누르는 순간에만 한번 실행
        ㄴInput.GetKeyUp <눌렀다 떼는 순간에만 한번
        ---
        Output for 1 second from the moment you turn to update and press space
        ㄴInInput.GetKeyDown < Run once only as soon as you press it
        ㄴㄴInInput.GetKeyUp < Just once when you press and take it off
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

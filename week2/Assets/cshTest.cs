using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//unity Create a custom class (script) by inheriting the operation function class (<parent)
//unity동작기능 클래스(<부모) 상속받아서 커스텀 클래스(스크립트)작성
public class NewBehaviourScript : MonoBehaviour
{
    //public 변수 = 유니티 내에 변수 등록됨(엔진내에서 수정가능)
    //ㄴ여러 개체에 넣을 경우 수치만 바꿔서 다양한 (속도,회전,이동..)등의 값 지정가능
    //public variable = variable registered within Unity (modifiable within engine)
    //ㄴWhen put in multiple objects, you can specify various values (speed, rotation, movement, etc.) by changing only the number
    public int num;

    //지정하지 않을겨우  private로 지정됨.
    // Specifies that it is not specified as well as specified.
    int PrivNum;

    //외부에서 접근 가능한 함수 생성
    //Create externally accessible functions
    public void Test()
    {

    }


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(num);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }
}

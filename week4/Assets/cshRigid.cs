using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //오브젝트 내 Rigidbody 스크립트 찾아서 연동.힘추가(힘방향 * 양 *시간값통일(누적 이동이라))
            //*조건인 컴포넌트가 있어야함*
            GetComponent<Rigidbody>().AddForce(Vector3.forward * 300 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back * 300 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * 300 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * 300 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.U))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 300 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.down * 300 * Time.deltaTime);
        }

    }
}

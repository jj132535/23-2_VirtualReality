using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject prefab;

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject go = GameObject.Instantiate(prefab) as GameObject;
            go.transform.position = new Vector3(Random.Range(-2.0f, 2.0f), 1.0f, 1.0f);
        }

        //A키 누르는 순간 : z축 랜덤으로 즉시 이동(0~0.5)
        //The moment you press the A key: Move immediately to the z-axis randomly (0-0.5)
        if (Input.GetKeyDown(KeyCode.A)){
		float rnd = Random.Range(0.0f, 0.5f);

		//각 좌표값은 private로 지정되어있어 변경시 일괄 지정해줘야함.
		//Each coordinate value is designated as private, so it must be specified collectively when changing.
		this.transform.position = new Vector3(0.0f, 1.0f, rnd);
	}

	//B키 누르는 순간 : z축 랜덤으로 즉시 회전(0~360)
	if(Input.GetKeyDown(KeyCode.B)){
		float rnd = Random.Range(0.0f, 360.0f);

		/*new Vector3로 회전값 반복 수행시 수학적 오류발생
		Quaternion: 4로 쪼개서 (회전량,회전x축,y,z축)으로 방향 명확히 함.
		Euler: 다시 3차원 벡터값으로 변환
		-
		Mathematical error occurs when repeating rotation values with new Vector3
		Quaternion: Split into 4 and clarify the direction (rotation, rotation x axis, y, z axis).
		Euler: Convert back to 3D vector values
		*/
		this.transform.rotation = Quaternion.Euler (rnd, 0.0f, 0.0f);
	}

		//=============================
		//up키 누르면 Translate(이동값x,y,z) * 속도 : 이동(순간이동x)
		//press Up key to Translate (move x,y,z) * Speed: Move (move x)

		//1초에  3.0f이동
		//Time.deltaTime<플랫폼마다 업데이트 주기가 불규칙한 것(성능차이)을 동일한 값만큼 이동하도록 잡아줌
		if(Input.GetKey(KeyCode.UpArrow)){
			this.transform.Translate (new Vector3 (0.0f, 0.0f, 3.0f * Time.deltaTime));
		}

		//Down으로 뒤로 Translate
		//press Down to Translate back
		if (Input.GetKey(KeyCode.DownArrow))
		{
			this.transform.Translate(new Vector3(0.0f, 0.0f,-3.0f * Time.deltaTime));
		}
        //left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(new Vector3(-0.1f, 0.0f, 0.0f * Time.deltaTime));
        }
        //right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(new Vector3(0.1f, 0.0f, 0.0f * Time.deltaTime));
        }

        //초당 +90도 회전
        if (Input.GetKey(KeyCode.R))
        {
            this.transform.Rotate(90.0f * Time.deltaTime, 0.0f, 0.0f);
        }

		//초당 -90도 회전
        if (Input.GetKey(KeyCode.L))
        {
            this.transform.Rotate(-90.0f * Time.deltaTime, 0.0f, 0.0f);
        }

    }

}

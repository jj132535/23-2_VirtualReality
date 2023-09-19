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

        //AŰ ������ ���� : z�� �������� ��� �̵�(0~0.5)
        //The moment you press the A key: Move immediately to the z-axis randomly (0-0.5)
        if (Input.GetKeyDown(KeyCode.A)){
		float rnd = Random.Range(0.0f, 0.5f);

		//�� ��ǥ���� private�� �����Ǿ��־� ����� �ϰ� �����������.
		//Each coordinate value is designated as private, so it must be specified collectively when changing.
		this.transform.position = new Vector3(0.0f, 1.0f, rnd);
	}

	//BŰ ������ ���� : z�� �������� ��� ȸ��(0~360)
	if(Input.GetKeyDown(KeyCode.B)){
		float rnd = Random.Range(0.0f, 360.0f);

		/*new Vector3�� ȸ���� �ݺ� ����� ������ �����߻�
		Quaternion: 4�� �ɰ��� (ȸ����,ȸ��x��,y,z��)���� ���� ��Ȯ�� ��.
		Euler: �ٽ� 3���� ���Ͱ����� ��ȯ
		-
		Mathematical error occurs when repeating rotation values with new Vector3
		Quaternion: Split into 4 and clarify the direction (rotation, rotation x axis, y, z axis).
		Euler: Convert back to 3D vector values
		*/
		this.transform.rotation = Quaternion.Euler (rnd, 0.0f, 0.0f);
	}

		//=============================
		//upŰ ������ Translate(�̵���x,y,z) * �ӵ� : �̵�(�����̵�x)
		//press Up key to Translate (move x,y,z) * Speed: Move (move x)

		//1�ʿ�  3.0f�̵�
		//Time.deltaTime<�÷������� ������Ʈ �ֱⰡ �ұ�Ģ�� ��(��������)�� ������ ����ŭ �̵��ϵ��� �����
		if(Input.GetKey(KeyCode.UpArrow)){
			this.transform.Translate (new Vector3 (0.0f, 0.0f, 3.0f * Time.deltaTime));
		}

		//Down���� �ڷ� Translate
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

        //�ʴ� +90�� ȸ��
        if (Input.GetKey(KeyCode.R))
        {
            this.transform.Rotate(90.0f * Time.deltaTime, 0.0f, 0.0f);
        }

		//�ʴ� -90�� ȸ��
        if (Input.GetKey(KeyCode.L))
        {
            this.transform.Rotate(-90.0f * Time.deltaTime, 0.0f, 0.0f);
        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//unity Create a custom class (script) by inheriting the operation function class (<parent)
//unity���۱�� Ŭ����(<�θ�) ��ӹ޾Ƽ� Ŀ���� Ŭ����(��ũ��Ʈ)�ۼ�
public class NewBehaviourScript : MonoBehaviour
{
    //public ���� = ����Ƽ ���� ���� ��ϵ�(���������� ��������)
    //������ ��ü�� ���� ��� ��ġ�� �ٲ㼭 �پ��� (�ӵ�,ȸ��,�̵�..)���� �� ��������
    //public variable = variable registered within Unity (modifiable within engine)
    //��When put in multiple objects, you can specify various values (speed, rotation, movement, etc.) by changing only the number
    public int num;

    //�������� �����ܿ�  private�� ������.
    // Specifies that it is not specified as well as specified.
    int PrivNum;

    //�ܺο��� ���� ������ �Լ� ����
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

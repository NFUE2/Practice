using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DotweenTest : MonoBehaviour
{
    [SerializeField]
    Transform target;


    // Update is called once per frame
    void Update()
    {
        Moving();
        //transform.DOMove();
    }

    void Moving()
    {
        if (Input.GetMouseButtonDown(0))
        {

            //transform.DOMove(target.position,1.0f); //target.position���� 1�ʸ��� �̵� 
            //transform.DOMove(target.position, 1.0f).From(); //target.position���� ���� ��ġ�� 1�ʸ��� �̵�

            //SetLoops(A,B) A�� �ݺ�Ƚ��
            //transform.DOMove(target.position, 1.0f).SetLoops(3,LoopType.Restart); //����ġ���� �������
            //transform.DOMove(target.position, 1.0f).SetLoops(5, LoopType.Yoyo); //���ó�� �̵��ϴµ� �ݺ�Ƚ���� ���� �����
            //transform.DOMove(target.position, 1.0f).SetLoops(1, LoopType.Incremental); //�΋H�ļ� �з����� ��ó�� �̵��� 1���ϸ� DOMove�� ���� 1���ں��� �з���

            //transform.DOScale(2.0f,1.0f); //ũ�Ⱑ ����� 
            //transform.DORotate(new Vector3(45, 45, 45), 1.0f); //ȸ��

            //OnComplete�� �۾��� ������ ����Ǵ� delegate �Լ�, ���� ���� 
            //transform.DOMove(target.position, 1.0f).SetLoops(3, LoopType.Restart).onComplete = Call;
            //transform.DOMove(target.position, 1).OnComplete(() => Debug.Log(1)); //���ٽ� ���


        }
    }

    void Call()
    {
        Debug.Log("��");
    }
}

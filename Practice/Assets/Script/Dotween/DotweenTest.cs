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

            //transform.DOMove(target.position,1.0f); //target.position으로 1초만에 이동 
            //transform.DOMove(target.position, 1.0f).From(); //target.position에서 기존 위치로 1초만에 이동

            //SetLoops(A,B) A는 반복횟수
            //transform.DOMove(target.position, 1.0f).SetLoops(3,LoopType.Restart); //원위치에서 재시작함
            //transform.DOMove(target.position, 1.0f).SetLoops(5, LoopType.Yoyo); //요요처럼 이동하는데 반복횟수는 편도로 계산함
            //transform.DOMove(target.position, 1.0f).SetLoops(1, LoopType.Incremental); //부딫쳐서 밀려나는 것처럼 이동함 1번하면 DOMove와 같음 1번뒤부터 밀려남

            //transform.DOScale(2.0f,1.0f); //크기가 변경됨 
            //transform.DORotate(new Vector3(45, 45, 45), 1.0f); //회전

            //OnComplete는 작업이 끝난후 실행되는 delegate 함수, 인자 없음 
            //transform.DOMove(target.position, 1.0f).SetLoops(3, LoopType.Restart).onComplete = Call;
            //transform.DOMove(target.position, 1).OnComplete(() => Debug.Log(1)); //람다식 사용


        }
    }

    void Call()
    {
        Debug.Log("끝");
    }
}

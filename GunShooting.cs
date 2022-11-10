using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShooting : WeaponBoxFunction
{
    //총알 프리팹
    public GameObject bullet;
    //생성되는 총알을 임시 저장하는 오브젝트
    private GameObject spawn_obj;
    //장탄수
    private int bulletNum = 10;
    //대기시간
    static float WaitTime = 0.3f;
    //장전확인
    private bool checkReLoad = true;

    //업데이트
    void Update()
    {
        //중지 트리거 눌렀을시 장전
        if (ClickMiddleTrigger(controller))
        {
            //장전여부
            checkReLoad = false;
            //장전 대기
            StartCoroutine(WaitingReLoad());
        }
        //검지 트리거를 눌렀을시 격발
        else if (ClickFrontTrigger(controller) && checkReLoad)
        {
            //총알을 만들어 총구 위치에 맞춰서 발사
            spawn_obj = Instantiate(bullet, transform.position, transform.rotation);
            spawn_obj.transform.Translate(0, 0.08f, 0.08f);
            spawn_obj.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
            //총알이 다 떨어지면 자동으로 장전
            bulletNum--;
            if (bulletNum == 0)
            {
                //장전 상태 해제
                checkReLoad = false;
                //장전 대기
                StartCoroutine(WaitingReLoad());
            }
        }
    }

    //장전모션 코루틴
    IEnumerator WaitingReLoad()
    {
        //총알을 모두 소모한 뒤 대기시간
        yield return new WaitForSeconds(WaitTime);
        //장전 소리 재생
        GetComponent<AudioSource>().Play();
        //0.1초간 진동
        TurnOnVibration(controller);
        yield return new WaitForSeconds(0.1f);
        TurnOffVibration(controller);
        //장전 대기 시간
        yield return new WaitForSeconds(WaitTime);
        //총알 리필
        bulletNum = 10;
        //장전 완료
        checkReLoad = true;
    }
}
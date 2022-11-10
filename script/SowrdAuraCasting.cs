using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SowrdAuraCasting : WeaponBoxFunction
{
    //소드오러 오브젝트
    public GameObject swordAura;
    //임시저장 오브젝트
    private GameObject spawnObj;
    //상태
    public bool readySwordAura = true;
    //캐스팅 시간
    private float castingTime = 1f;
    //칼 끝 시작, 끝 vector
    private Vector3 startPos;
    private Quaternion startRot;
    private Vector3 endPos;
    private Quaternion endRot;
    //기준 거리
    private float valDistance = 1f;


    //검끝 위치
    private GameObject point;

    private void Start()
    {
        point = transform.GetChild(0).gameObject;
    }


    // Update is called once per frame
    void Update()
    {
        if (PressingA_X(controller) && readySwordAura)
        {
            //누르고 있는동안 진동
            TurnOnVibration(controller);
            //캐스팅타임 0이되면 캐스팅완료상태로 변경
            castingTime -= Time.deltaTime;
            if (castingTime < 0)
            {
                readySwordAura = false;
                //캐스팅완료시 진동 멈춤
               TurnOffVibration(controller);
                //검기 시작 위치 저장
                StartCoroutine(ActiveSwordAura());
            }
        }
        //중간에 A_X버튼 떼면
        if (castingTime > 0 && !PressingA_X(controller))
        {
            //진동 멈춤
            TurnOffVibration(controller);
            //캐스팅 타임 초기화
            castingTime = 1f;
        }
    }

    //소드오러 발동 코루틴
    IEnumerator ActiveSwordAura()
    {
        //시작 좌표 저장
        startPos = point.transform.position;
        startRot = point.transform.rotation;
        yield return new WaitForSeconds(0.5f);
        // 0.5초후 좌표 저장
        endPos = point.transform.position;
        endRot = point.transform.rotation;
        //저장된 좌표간의 거리가 지정된 거리보다 클 시
        if (valDistance < (endPos - startPos).sqrMagnitude)
        {
            //시작 끝 보간
            Vector3 midPos = Vector3.Slerp(startPos, endPos, 0.5f);
            Quaternion midRot = Quaternion.Slerp(startRot, endRot, 0.5f);
            //각도 제한 : rot.x -> -90 ~ 0, rot.y -60 ~ 60
            Vector3 clampAngle = midRot.eulerAngles;
            clampAngle.x = (clampAngle.x > 180) ? clampAngle.x - 360 : clampAngle.x;
            clampAngle.x = Mathf.Clamp(clampAngle.x, -90f, 0f);
            clampAngle.y = (clampAngle.y > 180) ? clampAngle.y - 360 : clampAngle.y;
            clampAngle.y = Mathf.Clamp(clampAngle.y, -60f, 60f);
            midRot = Quaternion.Euler(clampAngle);

            //검기생성
            spawnObj = Instantiate(swordAura, midPos, midRot);
            spawnObj.GetComponent<Rigidbody>().AddForce(spawnObj.transform.forward * 200);
            //2초간 쿨타임
            yield return new WaitForSeconds(2f);
            yield return StartCoroutine(FinishSwordAura());
        }
        yield return StartCoroutine(FinishSwordAura());
    }
    //A_X버튼 누르고 있는 여부 확인 후 변수초기화
    IEnumerator FinishSwordAura()
    {
        yield return new WaitUntil(() => !PressingA_X(controller));
        castingTime = 1f;
        startPos = default;
        endPos = default;
        readySwordAura = true;
    }
}

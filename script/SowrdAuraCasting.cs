using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SowrdAuraCasting : WeaponBoxFunction
{
    //�ҵ���� ������Ʈ
    public GameObject swordAura;
    //�ӽ����� ������Ʈ
    private GameObject spawnObj;
    //����
    public bool readySwordAura = true;
    //ĳ���� �ð�
    private float castingTime = 1f;
    //Į �� ����, �� vector
    private Vector3 startPos;
    private Quaternion startRot;
    private Vector3 endPos;
    private Quaternion endRot;
    //���� �Ÿ�
    private float valDistance = 1f;


    //�˳� ��ġ
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
            //������ �ִµ��� ����
            TurnOnVibration(controller);
            //ĳ����Ÿ�� 0�̵Ǹ� ĳ���ÿϷ���·� ����
            castingTime -= Time.deltaTime;
            if (castingTime < 0)
            {
                readySwordAura = false;
                //ĳ���ÿϷ�� ���� ����
               TurnOffVibration(controller);
                //�˱� ���� ��ġ ����
                StartCoroutine(ActiveSwordAura());
            }
        }
        //�߰��� A_X��ư ����
        if (castingTime > 0 && !PressingA_X(controller))
        {
            //���� ����
            TurnOffVibration(controller);
            //ĳ���� Ÿ�� �ʱ�ȭ
            castingTime = 1f;
        }
    }

    //�ҵ���� �ߵ� �ڷ�ƾ
    IEnumerator ActiveSwordAura()
    {
        //���� ��ǥ ����
        startPos = point.transform.position;
        startRot = point.transform.rotation;
        yield return new WaitForSeconds(0.5f);
        // 0.5���� ��ǥ ����
        endPos = point.transform.position;
        endRot = point.transform.rotation;
        //����� ��ǥ���� �Ÿ��� ������ �Ÿ����� Ŭ ��
        if (valDistance < (endPos - startPos).sqrMagnitude)
        {
            //���� �� ����
            Vector3 midPos = Vector3.Slerp(startPos, endPos, 0.5f);
            Quaternion midRot = Quaternion.Slerp(startRot, endRot, 0.5f);
            //���� ���� : rot.x -> -90 ~ 0, rot.y -60 ~ 60
            Vector3 clampAngle = midRot.eulerAngles;
            clampAngle.x = (clampAngle.x > 180) ? clampAngle.x - 360 : clampAngle.x;
            clampAngle.x = Mathf.Clamp(clampAngle.x, -90f, 0f);
            clampAngle.y = (clampAngle.y > 180) ? clampAngle.y - 360 : clampAngle.y;
            clampAngle.y = Mathf.Clamp(clampAngle.y, -60f, 60f);
            midRot = Quaternion.Euler(clampAngle);

            //�˱����
            spawnObj = Instantiate(swordAura, midPos, midRot);
            spawnObj.GetComponent<Rigidbody>().AddForce(spawnObj.transform.forward * 200);
            //2�ʰ� ��Ÿ��
            yield return new WaitForSeconds(2f);
            yield return StartCoroutine(FinishSwordAura());
        }
        yield return StartCoroutine(FinishSwordAura());
    }
    //A_X��ư ������ �ִ� ���� Ȯ�� �� �����ʱ�ȭ
    IEnumerator FinishSwordAura()
    {
        yield return new WaitUntil(() => !PressingA_X(controller));
        castingTime = 1f;
        startPos = default;
        endPos = default;
        readySwordAura = true;
    }
}

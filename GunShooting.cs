using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShooting : WeaponBoxFunction
{
    //�Ѿ� ������
    public GameObject bullet;
    //�����Ǵ� �Ѿ��� �ӽ� �����ϴ� ������Ʈ
    private GameObject spawn_obj;
    //��ź��
    private int bulletNum = 10;
    //���ð�
    static float WaitTime = 0.3f;
    //����Ȯ��
    private bool checkReLoad = true;

    //������Ʈ
    void Update()
    {
        //���� Ʈ���� �������� ����
        if (ClickMiddleTrigger(controller))
        {
            //��������
            checkReLoad = false;
            //���� ���
            StartCoroutine(WaitingReLoad());
        }
        //���� Ʈ���Ÿ� �������� �ݹ�
        else if (ClickFrontTrigger(controller) && checkReLoad)
        {
            //�Ѿ��� ����� �ѱ� ��ġ�� ���缭 �߻�
            spawn_obj = Instantiate(bullet, transform.position, transform.rotation);
            spawn_obj.transform.Translate(0, 0.08f, 0.08f);
            spawn_obj.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
            //�Ѿ��� �� �������� �ڵ����� ����
            bulletNum--;
            if (bulletNum == 0)
            {
                //���� ���� ����
                checkReLoad = false;
                //���� ���
                StartCoroutine(WaitingReLoad());
            }
        }
    }

    //������� �ڷ�ƾ
    IEnumerator WaitingReLoad()
    {
        //�Ѿ��� ��� �Ҹ��� �� ���ð�
        yield return new WaitForSeconds(WaitTime);
        //���� �Ҹ� ���
        GetComponent<AudioSource>().Play();
        //0.1�ʰ� ����
        TurnOnVibration(controller);
        yield return new WaitForSeconds(0.1f);
        TurnOffVibration(controller);
        //���� ��� �ð�
        yield return new WaitForSeconds(WaitTime);
        //�Ѿ� ����
        bulletNum = 10;
        //���� �Ϸ�
        checkReLoad = true;
    }
}
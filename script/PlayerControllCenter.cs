using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllCenter : MonoBehaviour
{
    //Cotroller type
    public OVRInput.Controller controller;

    //WeaponBox �õ�
    private GameObject LeftWeaponBox;
    private GameObject RightWeaponBox;
   

    // Start is called before the first frame update
    void Start()
    {
        LeftWeaponBox = GameObject.Find("LeftWeaponBox");
        RightWeaponBox = GameObject.Find("RightWeaponBox");
        //StartGame = true;

        LeftWeaponBox.SetActive(true);
        RightWeaponBox.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {   
        
    }

    #region ��Ʈ�ѷ� ���� ����
    //���� ���ļ� ����
    static public float frequency = 0.3f;
    static public float ampitude = 0.2f;

    public void TurnOnVibration(OVRInput.Controller controller) { OVRInput.SetControllerVibration(frequency, ampitude, controller); }   //���� �ѱ�
    public void TurnOffVibration(OVRInput.Controller controller) { OVRInput.SetControllerVibration(0, 0, controller); }                 //���� ����
    #endregion

    #region ��Ʈ�ѷ� ����
    public bool ClickFrontTrigger(OVRInput.Controller controller) { return OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, controller); }     //���� Ʈ����
    public bool ClickMiddleTrigger(OVRInput.Controller controller) { return OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, controller); }     //���� Ʈ����

    public bool ClickA_X(OVRInput.Controller controller) { return OVRInput.GetDown(OVRInput.Button.One, controller); }                              //A or X ��ư
    public bool ClickB_Y(OVRInput.Controller controller) { return OVRInput.GetDown(OVRInput.Button.Two, controller); }                              //B or Y ��ư

    public bool StickLeft(OVRInput.Controller controller) { return OVRInput.GetDown(OVRInput.Button.PrimaryThumbstickLeft, controller); }           //��ƽ ����
    public bool StickRight(OVRInput.Controller controller) { return OVRInput.GetDown(OVRInput.Button.PrimaryThumbstickRight, controller); }         //��ƽ ������
    public bool StickUp(OVRInput.Controller controller) { return OVRInput.GetDown(OVRInput.Button.PrimaryThumbstickUp, controller); }               //��ƽ ����
    public bool StickDown(OVRInput.Controller controller) { return OVRInput.GetDown(OVRInput.Button.PrimaryThumbstickDown, controller); }           //��ƽ �Ʒ���

    public bool PressingA_X(OVRInput.Controller controller) { return OVRInput.Get(OVRInput.Button.One, controller); }                               //A or X Ȧ��
    public bool PressingB_Y(OVRInput.Controller controller) { return OVRInput.Get(OVRInput.Button.Two, controller); }                               //B or Y Ȧ��
    #endregion


}
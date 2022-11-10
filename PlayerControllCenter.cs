using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllCenter : MonoBehaviour
{
    //Cotroller type
    public OVRInput.Controller controller;

    //WeaponBox 시동
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

    #region 컨트롤러 진동 조작
    //진동 주파수 설정
    static public float frequency = 0.3f;
    static public float ampitude = 0.2f;

    public void TurnOnVibration(OVRInput.Controller controller) { OVRInput.SetControllerVibration(frequency, ampitude, controller); }   //진동 켜기
    public void TurnOffVibration(OVRInput.Controller controller) { OVRInput.SetControllerVibration(0, 0, controller); }                 //진동 끄기
    #endregion

    #region 컨트롤러 조작
    public bool ClickFrontTrigger(OVRInput.Controller controller) { return OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, controller); }     //검지 트리거
    public bool ClickMiddleTrigger(OVRInput.Controller controller) { return OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, controller); }     //중지 트리거

    public bool ClickA_X(OVRInput.Controller controller) { return OVRInput.GetDown(OVRInput.Button.One, controller); }                              //A or X 버튼
    public bool ClickB_Y(OVRInput.Controller controller) { return OVRInput.GetDown(OVRInput.Button.Two, controller); }                              //B or Y 버튼

    public bool StickLeft(OVRInput.Controller controller) { return OVRInput.GetDown(OVRInput.Button.PrimaryThumbstickLeft, controller); }           //스틱 왼쪽
    public bool StickRight(OVRInput.Controller controller) { return OVRInput.GetDown(OVRInput.Button.PrimaryThumbstickRight, controller); }         //스틱 오른쪽
    public bool StickUp(OVRInput.Controller controller) { return OVRInput.GetDown(OVRInput.Button.PrimaryThumbstickUp, controller); }               //스틱 위쪽
    public bool StickDown(OVRInput.Controller controller) { return OVRInput.GetDown(OVRInput.Button.PrimaryThumbstickDown, controller); }           //스틱 아래쪽

    public bool PressingA_X(OVRInput.Controller controller) { return OVRInput.Get(OVRInput.Button.One, controller); }                               //A or X 홀드
    public bool PressingB_Y(OVRInput.Controller controller) { return OVRInput.Get(OVRInput.Button.Two, controller); }                               //B or Y 홀드
    #endregion


}
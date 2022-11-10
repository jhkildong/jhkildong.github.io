using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponBoxFunction : PlayerControllCenter
{
    #region 전역 멤버
    static readonly int ArraySize = 4;
    private int currentIdx;
    private int activeWeaponIdx;
    private GameObject BoxUI;
    private List<GameObject> WeaponList;
    private List<Button> UIbtn;

    private int Mod(int a, int b) { int result = a % b; return result < 0 ? result + b : result; }
    #endregion  

    //웨펀박스 조작준비
    private void InitWeaponBox()
    {
        WeaponList = new List<GameObject>();
        UIbtn = new List<Button>();
        BoxUI = new GameObject();

        Transform[] children = GetComponentsInChildren<Transform>(true);

        foreach (Transform child in children)
        {
            if (child.CompareTag("Weapon"))
                WeaponList.Add(child.gameObject);
            else if (child.CompareTag("WeaponBox"))
                BoxUI = child.gameObject;
        }

        Transform[] UItransform = BoxUI.GetComponentsInChildren<Transform>(true);

        foreach (Transform button in UItransform)
        {
            if (button.CompareTag("Button"))
                UIbtn.Add(button.GetComponent<Button>());
        }

        BoxUI.SetActive(false);
        WeaponList[0].SetActive(true);
        WeaponList[1].SetActive(false);
        WeaponList[2].SetActive(false);
        WeaponList[3].SetActive(false);

        currentIdx = 0;
        activeWeaponIdx = 0;
    }

    private void Start()
    {
        InitWeaponBox();
    }

    void Update()
    {        
        if(ClickB_Y(controller))
        {
            if(!BoxUI.activeSelf)
            {
                BoxUI.SetActive(true);
                currentIdx = 0;
                UIbtn[currentIdx].interactable = false;
            }
            else
                BoxUI.SetActive(false);
        }
        if(BoxUI.activeSelf)
        {
            if (StickLeft(controller))
            {
                UIbtn[currentIdx].interactable = true;
                currentIdx =  Mod(currentIdx - 1, ArraySize);
                UIbtn[currentIdx].interactable = false;
            }
            else if (StickRight(controller))
            {
                UIbtn[currentIdx].interactable = true;
                currentIdx = Mod(currentIdx + 1, ArraySize);
                UIbtn[currentIdx].interactable = false;
            }
            else if(StickUp(controller))
            {
                WeaponList[activeWeaponIdx].SetActive(false);
                WeaponList[currentIdx].SetActive(true);
                UIbtn[currentIdx].interactable = true;
                activeWeaponIdx = currentIdx;
                BoxUI.SetActive(false);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadBook : MonoBehaviour
{
    public GameObject bookUI; // UI GameObject을 Inspector에서 연결해야 합니다.

    void OnTriggerEnter(Collider collision)
    {
        // 충돌이 발생하면 UI를 활성화합니다.
        if (collision.gameObject.CompareTag("Desk")) // 적절한 태그를 사용하세요.
        {
            ShowUI();
        }
    }

    void OnTriggerExit(Collider collision)
    {
        // 충돌이 빠져나가면 UI를 비활성화합니다.
        if (collision.gameObject.CompareTag("Desk")) // 적절한 태그를 사용하세요.
        {
            HideUI();
        }
    }

    void HideUI()
    {
        // UI를 비활성화합니다.
        if (bookUI != null)
        {
            bookUI.SetActive(false);
        }
    }


    void ShowUI()
    {
        // UI를 활성화하거나 생성합니다.
        if (bookUI != null)
        {
            bookUI.SetActive(true);
        }
    }
}





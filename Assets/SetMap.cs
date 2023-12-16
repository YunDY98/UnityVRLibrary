using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMap : MonoBehaviour
{
    public GameObject DeepSeaScene;

    void Start()
    {
        // 게임 시작 시 오브젝트를 활성화 상태로 설정
       
    }


    public void OnDeepSea()
    {
        DeepSeaScene.SetActive(true);
    }

    public void OffDeepSea()
    {
        DeepSeaScene.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMap : MonoBehaviour
{
    public GameObject DeepSeaScene;
    public GameObject ForestScene;

    void Start()
    {
        // 게임 시작 시 오브젝트를 활성화 상태로 설정
       
    }

    void Awake()
    {
        DeepSeaScene.SetActive(false);
        ForestScene.SetActive(false);
    }


    public void OnDeepSea()
    {
        DeepSeaScene.SetActive(true);
    }

    public void OffDeepSea()
    {
        DeepSeaScene.SetActive(false);
    }

     public void OnForest()
    {
        ForestScene.SetActive(true);
    }

    public void OffForest()
    {
        ForestScene.SetActive(false);
    }
}

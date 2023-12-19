using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setObject : MonoBehaviour
{
    public GameObject setobject;

    bool isused = true;

    void Start()
    {
        // 게임 시작 시 오브젝트를 활성화 상태로 설정
       
    }

    void Awake()
    {
       setobject.SetActive(false);
    
    }


    public void OnOffObject()
    {
        if(isused)
        {
            setobject.SetActive(true);
            isused = false;

        }
        else
        {
            setobject.SetActive(false);
            isused = true;
        }
        
    }

    public void OffObject()
    {
        setobject.SetActive(false);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setObject : MonoBehaviour
{
    public GameObject setobject;
    

    bool isused = true;

    void Start()
    {
       
       
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

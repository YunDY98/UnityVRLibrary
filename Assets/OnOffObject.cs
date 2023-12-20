using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffObject : MonoBehaviour
{
    public GameObject DefaultOnobject;
    

    bool isused = true;

    void Start()
    {
       
       
    }

  


    public void DefaultOnObject()
    {
        if(isused)
        {
            DefaultOnobject.SetActive(false);
            isused = false;

        }
        else
        {
            DefaultOnobject.SetActive(true);
            isused = true;
        }
        
    }
}

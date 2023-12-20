using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSecene : MonoBehaviour
{
    
    public GameObject Scene;
    public void OnTriggerEnter()
    {
       Scene.SetActive(true);
    }
}

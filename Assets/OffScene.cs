using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffScene : MonoBehaviour
{
    public GameObject Scene;

    void Awake()
    {
        Scene.SetActive(false);
    }
    public void OnTriggerEnter()
    {
       Scene.SetActive(false);
    }
}

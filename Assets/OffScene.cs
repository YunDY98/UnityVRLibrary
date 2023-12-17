using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffScene : MonoBehaviour
{
    public GameObject Scene;
    public void OnTriggerEnter()
    {
       Scene.SetActive(false);
    }
}

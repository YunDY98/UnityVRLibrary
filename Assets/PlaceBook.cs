using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceBook : MonoBehaviour
{
    public RectTransform PachinkorectTransform;
    public RectTransform DollarrectTransform;
    public RectTransform JusticerectTransform;
    public RectTransform ElonrectTransform;
    public RectTransform SuzumerectTransform;
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("ElonMusk"))
        {
            ElonrectTransform.localRotation = Quaternion.Euler(new Vector3(0f, -90f, 0f));
        }

        if(other.CompareTag("Suzume"))
        {
            SuzumerectTransform.localRotation = Quaternion.Euler(new Vector3(0f, -90f, 0f));

        }

        if(other.CompareTag("Pachinko"))
        {
            PachinkorectTransform.localRotation = Quaternion.Euler(new Vector3(0f, -90f, 0f));

        }

        if(other.CompareTag("Dollar"))
        {
            DollarrectTransform.localRotation = Quaternion.Euler(new Vector3(0f, -90f, 0f));

        }

        if(other.CompareTag("Justice"))
        {
            JusticerectTransform.localRotation = Quaternion.Euler(new Vector3(0f, -90f, 0f));

        }
        
        
    }
}

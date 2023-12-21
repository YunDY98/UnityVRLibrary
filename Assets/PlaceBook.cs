using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceBook : MonoBehaviour
{
    public RectTransform PachinkorectTransform;

    public Transform PachinkoInit;
    public RectTransform DollarrectTransform;

    public Transform DollarInit;
    public RectTransform JusticerectTransform;

     public Transform JusticeInit;
    public RectTransform ElonrectTransform;

     public Transform ElonInit;
    public RectTransform SuzumerectTransform;

     public Transform SuzumeInit;


  

    public void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("ElonMusk"))
        {
            ElonrectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            ElonrectTransform.position = ElonInit.position;
            
        }

        if(other.CompareTag("Suzume"))
        {
            SuzumerectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            SuzumerectTransform.position = SuzumeInit.position;

        }

        if(other.CompareTag("Pachinko"))
        {
            PachinkorectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            PachinkorectTransform.position = PachinkoInit.position;
        }

        if(other.CompareTag("Dollar"))
        {
            DollarrectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            DollarrectTransform.position = DollarInit.position;


        }

        if(other.CompareTag("Justice"))
        {
            JusticerectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            JusticerectTransform.position = JusticeInit.position;

        }
        
        
    }
}

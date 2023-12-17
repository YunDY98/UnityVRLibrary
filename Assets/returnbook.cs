using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returnbook : MonoBehaviour
{
    public GameObject PachinkoInit;
    public RectTransform PachinkorectTransform;

    public GameObject DollarInit;
    public RectTransform DollarrectTransform;

    public GameObject JusticeInit;
    public RectTransform JusticerectTransform;


  
    public GameObject ElonMuskInit;
    public RectTransform ElonrectTransform;

    public GameObject SuzumeInit;
    public RectTransform SuzumerectTransform;
    private float timer;
    bool isTrigger;

    void Update()
    {
         if(isTrigger)
         {
            timer += Time.deltaTime;
             
             
             
         }
 
    }
    
 
    public void OnTriggerStay(Collider other)
    {
 
        if(other.CompareTag("ElonMusk"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = ElonMuskInit.transform.position;
                isTrigger = false;
                timer = 0;
         
              
           }
           
           

        }

        if(other.CompareTag("Suzume"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = SuzumeInit.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }

        if(other.CompareTag("Pachinko"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = PachinkoInit.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }

        if(other.CompareTag("Dollar"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = DollarInit.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }

        if(other.CompareTag("Justice"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = JusticeInit.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }





        
           

   }

}
    

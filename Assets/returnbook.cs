using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returnbook : MonoBehaviour
{
  
   public GameObject ElonMusk;
   public RectTransform ElonrectTransform;

    public GameObject Suzume;
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
       
       
   }

   public void OnTriggerStay(Collider other)
   {

        if(other.CompareTag("ElonMusk"))
        {
            isTrigger = true;
            if(timer > 3)
            {
                other.transform.position = ElonMusk.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }

         if(other.CompareTag("Suzume"))
        {
            isTrigger = true;
            if(timer > 3)
            {
                other.transform.position = Suzume.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }



        
           

   }

}
    

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returnbook : MonoBehaviour
{
  
   public GameObject ElonMusk;
   public RectTransform ElonrectTransform;
   private float timer;
   bool isTrigger;

   void Update()
   {
        if(isTrigger)
        {
            timer += Time.deltaTime;
            
            
            
        }

   }
   public void OnTriggerEnter()
   {
        
        ElonrectTransform.localRotation = Quaternion.Euler(new Vector3(0f, -90f, 0f));
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
           

   }

}
    

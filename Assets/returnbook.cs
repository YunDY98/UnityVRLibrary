using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returnbook : MonoBehaviour
{
  
   public GameObject ElonMusk;
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
        if(other.CompareTag("Book"))
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
    

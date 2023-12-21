using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returnbook : MonoBehaviour
{
    // public GameObject PachinkoInit;
    // public Gameobject PachinkorectGameobject;

    // public GameObject DollarInit;
    // public Gameobject DollarrectGameobject;

    // public GameObject JusticeInit;
    // public Gameobject JusticerectGameobject;


  
    // public GameObject ElonMuskInit;
    // public Gameobject ElonrectGameobject;

    // public GameObject SuzumeInit;
    // public Gameobject SuzumerectGameobject;

     public  RectTransform PachinkorectGameobject;

    public GameObject PachinkoInit;
    public  RectTransform DollarrectGameobject;

    public GameObject DollarInit;

   
    public  RectTransform JusticerectGameobject;

    public GameObject JusticeInit;
    public  RectTransform ElonrectGameobject;

    public GameObject ElonInit;
    public  RectTransform SuzumerectGameobject;

    public GameObject SuzumeInit;

    public  RectTransform SaynorectGameobject;

    public GameObject SaynoInit;

    public  RectTransform MoodrectTranform;

    public GameObject MoodInit;

    public  RectTransform TrendrectTrandform;

    public GameObject TrendInit;

    public  RectTransform BackingrectGameobject;

    public GameObject BackingInit;

    public RectTransform GoodbyerectGameobject;

    public GameObject GoodbyeInit;

    public  RectTransform TrainrectGameobject;

    public GameObject TrainInit;

    public  RectTransform MoodLiferectGameobject;

    public GameObject MoodLifeInit;

    public  RectTransform GoodLifeGoodRevnegerectGameobject;

    public GameObject GoodLifeGoodRevengeInit;

    public  RectTransform EarthrectGameobject;

    public GameObject EarthInit;

    public  RectTransform PoertyrectGameobject;

    public GameObject PoetryInit;

    public  RectTransform WarrectGameobject;

    public GameObject WarInit;

    public  RectTransform DeadrectGameobject;

    public GameObject DeadInit;

    public  RectTransform TraumarectGameobject;

    public GameObject TraumaInit;

    public  RectTransform HappyrectGameobject;

    public GameObject HappyInit;

    public  RectTransform CityrectGameobject;

    public GameObject CityInit;

    public  RectTransform FindrectGameobject;

    public GameObject FindInit;

    public  RectTransform FishrectGameobject;

    public  GameObject FishInit;

    public  RectTransform Dollar1rectGameobject;

    public GameObject Dollar1Init;

    public  RectTransform TonightrectGameobject;

    public GameObject TonightInit;

    public  RectTransform Trend2022rectGameobject;

    public GameObject Trend2022Init;


    
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
                other.transform.position = ElonInit.transform.position;
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

        if(other.CompareTag("Sayno"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = SaynoInit.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }

        if(other.CompareTag("Mood"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = MoodInit.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }

        if(other.CompareTag("2023"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = TrendInit.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }

        if(other.CompareTag("backing"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = BackingInit.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }

        if(other.CompareTag("Goodbye"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = GoodbyeInit.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }

        if(other.CompareTag("Train"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = TrainInit.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }

        if(other.CompareTag("MoodLife"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = MoodLifeInit.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }

        if(other.CompareTag("GoodLifeGoodRevenge"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = GoodLifeGoodRevengeInit.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }

        if(other.CompareTag("Earth"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = EarthInit.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }

        if(other.CompareTag("Poetry"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = PoetryInit.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }

        if(other.CompareTag("War"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = WarInit.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }

        if(other.CompareTag("Dead"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = DeadInit.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }

        if(other.CompareTag("Trauma"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = TraumaInit.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }

        if(other.CompareTag("Happy"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = HappyInit.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }

        if(other.CompareTag("City"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = CityInit.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }

        if(other.CompareTag("Find"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = FindInit.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }

        if(other.CompareTag("Fish"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = FishInit.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }

        if(other.CompareTag("2022"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = Trend2022Init.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }

        if(other.CompareTag("Dollar1"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = Dollar1Init.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }

         if(other.CompareTag("Tonight"))
        {
            isTrigger = true;

            if(timer > 3)
            {
                other.transform.position = TonightInit.transform.position;
                isTrigger = false;
                timer = 0;
          
               
            }
           
           

        }


       






        
           

   }

}
    

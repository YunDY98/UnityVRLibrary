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

    public RectTransform SaynorectTransform;

    public Transform SaynoInit;

    public RectTransform MoodrectTransform;

    public Transform MoodInit;

    public RectTransform TrendrectTrandform;

    public Transform TrendInit;

    public RectTransform BackingrectTransform;

    public Transform BackingInit;

    public RectTransform GoodbyerectTransform;

    public Transform GoodbyeInit;

    public RectTransform TrainrectTransform;

    public Transform TrainInit;

    public RectTransform MoodLiferectTransform;

    public Transform MoodLifeInit;

    public RectTransform GoodLifeGoodRevnegerectTransform;

    public Transform GoodLifeGoodRevengeInit;

    public RectTransform EarthrectTransform;

    public Transform EarthInit;

    public RectTransform PoertyrectTransform;

    public Transform PoertyInit;

    public RectTransform WarrectTransform;

    public Transform WarInit;

    public RectTransform DeadrectTransform;

    public Transform DeadInit;

    public RectTransform TraumarectTransform;

    public Transform TraumaInit;

    public RectTransform HappyrectTransform;

    public Transform HappyInit;

    public RectTransform CityrectTransform;

    public Transform CityInit;

    public RectTransform FindrectTransform;

    public Transform FindInit;

    public RectTransform FishrectTransform;

    public Transform FishInit;

    public RectTransform Dollar1rectTransform;

    public Transform Dollar1Init;

    public RectTransform TonightrectTransform;

    public Transform TonightInit;

    public RectTransform Trend2022rectTransform;

    public Transform Trend2022Init;






    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("ElonMusk"))
        {
            ElonrectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            ElonrectTransform.position = ElonInit.position;

        }

        if (other.CompareTag("Suzume"))
        {
            SuzumerectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            SuzumerectTransform.position = SuzumeInit.position;

        }

        if (other.CompareTag("Pachinko"))
        {
            PachinkorectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            PachinkorectTransform.position = PachinkoInit.position;
        }

        if (other.CompareTag("Dollar"))
        {
            DollarrectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            DollarrectTransform.position = DollarInit.position;


        }

        if (other.CompareTag("Justice"))
        {
            JusticerectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            JusticerectTransform.position = JusticeInit.position;

        }

        if (other.CompareTag("Sayno"))
        {
            SaynorectTransform.localRotation =  Quaternion.Euler(new Vector3(0f, 0f, 0f));
            SaynorectTransform.position = SaynoInit.position;

        }
        if (other.CompareTag("Mood"))
        {
            
            MoodrectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            MoodrectTransform.position = MoodInit.position;

        }
        if (other.CompareTag("2023"))
        {
            TrendrectTrandform.localRotation =  Quaternion.Euler(new Vector3(0f, 0f, 0f));
            TrendrectTrandform.position = TrendInit.position;


        }

        if (other.CompareTag("backing"))
        {
            BackingrectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            BackingrectTransform.position = BackingInit.position;



        }
        if (other.CompareTag("Goodbye"))
        {
            GoodbyerectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            GoodbyerectTransform.position = GoodbyeInit.position;

        }
        if (other.CompareTag("Train"))
        {
            TrainrectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            TrainrectTransform.position = TrainInit.position;


        }
        if (other.CompareTag("MoodLife"))
        {
            MoodLiferectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            MoodLiferectTransform.position = MoodLifeInit.position;


        }
        if (other.CompareTag("GoodLifeGoodRevenge"))
        {
            GoodLifeGoodRevnegerectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            GoodLifeGoodRevnegerectTransform.position = GoodLifeGoodRevengeInit.position;


        }
        if (other.CompareTag("Earth"))
        {
            EarthrectTransform.localRotation= Quaternion.Euler(new Vector3(0f, 0f, 0f));
            EarthrectTransform.position = EarthInit.position;


        }
        if (other.CompareTag("Poetry"))
        {
            PoertyrectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            PoertyrectTransform.position = PoertyInit.position;


        }
        if (other.CompareTag("War"))
        {
            WarrectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            WarrectTransform.position = WarInit.position;


        }
        if (other.CompareTag("Dead"))
        {
            DeadrectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            DeadrectTransform.position = DeadInit.position;


        }
        if (other.CompareTag("Trauma"))
        {
           TraumarectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
           TraumarectTransform.position = TraumaInit.position;
            


        }
        if (other.CompareTag("Happy"))
        {
            HappyrectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            HappyrectTransform.position = HappyInit.position;

        }
        if (other.CompareTag("City"))
        {
            CityrectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            CityrectTransform.position = CityInit.position;

        }

        if (other.CompareTag("Find"))
        {
            FindrectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            FindrectTransform.position = FindInit.position;


        }
        if (other.CompareTag("Fish"))
        {
            FishrectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            FishrectTransform.position = FishInit.position;
            

        }

         if (other.CompareTag("Dollar1"))
        {
            Dollar1rectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            Dollar1rectTransform.position = Dollar1Init.position;
            

        }

        if (other.CompareTag("Tonight"))
        {
            TonightrectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            TonightrectTransform.position = TonightInit.position;
            

        }

         if (other.CompareTag("2022"))
        {
           Trend2022rectTransform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            Trend2022rectTransform.position = Trend2022Init.position;
            

        }

        


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSkybox : MonoBehaviour
{
    public Material newSkyboxMaterial;
    public Material SkyboxMaterial;

    bool isbool = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeSkyboxmaterial()
    {
        if(isbool)
        {
            RenderSettings.skybox = newSkyboxMaterial;
            isbool = false;

        }
        else
        {
            RenderSettings.skybox = SkyboxMaterial;
            isbool = true;
        }
       
    }
}

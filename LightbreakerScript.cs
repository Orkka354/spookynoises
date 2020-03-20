using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightbreakerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //I know this might be spageti coding but this here is the singleton I use to make sure lights turn themselfs off after their aniamtion
        //just a simple destroy game object to see the old version go to MakeLight.cs
        Destroy(gameObject, 1.6f);
    } 

    // Update is called once per frame
    
}

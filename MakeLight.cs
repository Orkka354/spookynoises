using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeLight : MonoBehaviour
{
    public GameObject particlelight;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.current.spawnLight += Createlight;
    }
    public void Createlight()
    {
        Instantiate(particlelight, GameObject.FindGameObjectWithTag("Player").transform.position, Quaternion.identity);
        //Destroy(GameObject.Find("Particle System(Clone)"),1.0f);
        //StartCoroutine("Fadelight");
      
        
    }
    //Alright Don't laugh but this was an old method that would spawn a light make it grow over
    //Time and it was going to be modified so it would shrink but I learned about the particle 
    // system and light and it looks so much better so I kind of had to gut it 
    // but if you want it to work uncomment the IEnumerator Fadelight() and the start coroutine and it should work
    //Thankfully the observer takes care of the rest of the work.
    //IEnumerator Fadelight()
    //{
    //    float duration = 5.0f;
    //    float interval = 0.1f;
    //    Debug.Log("Creating light");

    //    GameObject lightC = new GameObject("the light");
    //    Light lightComp = lightC.AddComponent<Light>();
    //    lightComp.color = Color.yellow;

    //    lightComp.intensity = 2.0f;

    //    lightC.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;
    //    while(duration >= 0.0f)
    //    {
    //        lightComp.intensity += 0.2f;
    //        duration -= 0.1f;
    //        yield return new WaitForSeconds(0.1f);
    //    }
    //    Destroy(lightC, 30);
        
    //}
    

    // Update is called once per frame
    void Update()
    {
        //Honestly I only have this function in the update because there is the risk of a rouge light going off this due to spam
       // Destroy(GameObject.Find("Particle System(Clone)"), 1.0f);
    }
}

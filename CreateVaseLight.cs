using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateVaseLight : MonoBehaviour
{
    
    public GameObject particlelightVase;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.current.SmashLight += vaselight;
    }
    private void vaselight()

    {
        //here is the vase creation script
        Instantiate(particlelightVase,gameObject.transform.position, Quaternion.identity);
        
        //StartCoroutine("Fadelight");

    }
    private void OnDestroy()
    {
        GameManager.current.SmashLight -= vaselight;
    }
    //IEnumerator Fadelight()
    //{
    //    float duration = 5.0f;
    //  //  float interval = 0.1f;
    //    Debug.Log("Creating light");

    //    GameObject lightC = new GameObject("the light");
    //    Light lightComp = lightC.AddComponent<Light>();
    //    lightComp.color = Color.white;

    //    lightComp.range = 30.0f;

    //    lightC.transform.position = GameObject.FindGameObjectWithTag("vase").transform.position;
    //    while (duration >= 0.0f)
    //    {
    //        lightComp.range -= 0.2f;
    //        duration -= 0.1f;
    //        yield return new WaitForSeconds(0.1f);
    //    }
    //    Destroy(lightC, 10);

    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}

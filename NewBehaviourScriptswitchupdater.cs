using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScriptswitchupdater : MonoBehaviour
{
    public int id;
    public GameObject notify;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.current.Switch += updateswitchnotes;
    }

    // Update is called once per frame
    public void updateswitchnotes()
    {
        //here is an unimiplemented block spawner that would put blocks near you hand to tell you what doors you have opened and can run now.
        notify.SetActive(true);

    }
    
}

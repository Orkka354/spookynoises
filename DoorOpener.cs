using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public int id;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.current.onDoorwayTriggerEnter += OnDoorwayOpen;
    }
    private void OnDoorwayOpen(int id)
    {
        Debug.Log("Door Opening");
        if(id == this.id)
        {
            //special free asset lean tweens allows me to use movements withought needing animations
            LeanTween.moveLocalY(gameObject, 3.6f, 1f).setEaseOutQuad();
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

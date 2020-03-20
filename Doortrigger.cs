using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doortrigger : MonoBehaviour
{
    public int id;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "LeftHand" || other.gameObject.tag == "RightHand")
        {
            //trigger for hands to interact with buttons
            GameManager.current.DoorwayTriggerEnter(id);
           
            LeanTween.moveLocalY(gameObject, -1.3f, 1f).setEaseOutQuad();
        }
       
    }
}

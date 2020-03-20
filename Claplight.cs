using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Claplight : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LeftHand")
        {
            Debug.Log("claped");
            GameManager.current.spawninglight();
        }
    }
}

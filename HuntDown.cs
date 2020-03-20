using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuntDown : MonoBehaviour
{
    public StateController doggy;
    // Start is called before the first frame updateb
    void Start()
    {
        GameObject hunter = GameObject.FindWithTag("TheAi");
        doggy = hunter.GetComponent<StateController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("well we crashed");
            doggy.detectionRange = 100;
        }
    }
}

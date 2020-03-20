using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Just yells at the game manager to spawn a light at player clap
        GameManager.current.spawninglight();
    }
}

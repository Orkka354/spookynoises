using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Characterdeth : MonoBehaviour
{
    private Scene Ending;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Steve")
        {
            Debug.Log("claped");
            SceneManager.LoadScene(0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartlife : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LeftHand" || other.gameObject.tag =="RightHand")
        {
            
            SceneManager.LoadScene(2);
        }
    }
}

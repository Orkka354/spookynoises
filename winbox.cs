using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winbox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LeftHand")
        {
            Debug.Log("claped");
            SceneManager.LoadScene(1);
        }
    }
}

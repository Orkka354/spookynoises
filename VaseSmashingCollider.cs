using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseSmashingCollider : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            Destroy(this.gameObject);
            GameManager.current.SmashingLight();
            
        }
    }
}

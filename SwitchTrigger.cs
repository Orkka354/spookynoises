using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTrigger : MonoBehaviour
{
    public int id;
    private void OnTriggerEnter(Collider other)
    {
        GameManager.current.DoorwayTriggerEnter(id);
        GameManager.current.ActivateSwitch();
        Destroy(gameObject, 1f);
    }
}

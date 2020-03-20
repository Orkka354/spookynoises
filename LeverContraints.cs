using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverContraints : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Oh if your finding this well yeah this was my experiments with 
        //making levers but ultimately it really didn't work but its here if you wish to see what I tried.
    }

    // Update is called once per frame
    void Update()
    {
      float rotationx =  this.transform.rotation.x;
        float rotationy = this.transform.rotation.y;
        float rotationz = this.transform.rotation.z;


        //float xPosition = this.transform.localPosition.x;
       // float yPosition = this.transform.localPosition.y;
        //float zPosition = this.transform.localPosition.z;

      //  rotationx = Mathf.Clamp(rotationx, -10, 10);
      //  rotationy = Mathf.Clamp(rotationy, 0, 10);
       // rotationz = Mathf.Clamp(rotationz, -10, 10);

       // xPosition = Mathf.Clamp(this.transform.localPosition.x, -2, 1);
        //yPosition = Mathf.Clamp(this.transform.localPosition.y, 1, 1);
        //zPosition = Mathf.Clamp(this.transform.localPosition.z, -10, 10);

       // Vector3 clampedVector = new Vector3(xPosition,yPosition);
        Vector3 currentclamp = this.transform.localRotation.eulerAngles;
        currentclamp.y = Mathf.Clamp(currentclamp.y, 0, 0);
        currentclamp.x = Mathf.Clamp(currentclamp.x, 0, 0);
        currentclamp.z = Mathf.Clamp(currentclamp.z, 0, 0);

        this.transform.localRotation = Quaternion.Euler(currentclamp);

        //this.transform.rotation = Quaternion.Euler(rotationx, rotationy, rotationz);
    //    this.transform.localPosition = clampedVector;
    }
}

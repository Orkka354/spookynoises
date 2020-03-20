using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerKeyboard : MonoBehaviour
{
    private string moveInputAxis = "Vertical";
    private string turnInputAxis = "Horizontal";

    public float rotationRate = 360;
    public float moveSpeed = 2;

   
    /// <summary>
    /// oh this was primarially a testing controller for fps controls rather than vr so its not to important it was more for making light in the first place
    /// 
    /// </summary>
    // Update is called once per frame
    void Update()
    {
        float moveAxis = Input.GetAxis(moveInputAxis);
        float turnAxis = Input.GetAxis(turnInputAxis);

        ApplyInput(moveAxis, turnAxis);
        clap();
    }
    private void ApplyInput(float moveInput, float turnInput)
    {
        Move(moveInput);
        Turn(turnInput);
    }
    private void Move(float input)
    {
        transform.Translate(Vector3.forward * input * moveSpeed);
        
    }
    private void Turn(float input)
    {
        transform.Rotate(0, input * rotationRate * Time.deltaTime, 0);
    }
    private void clap()
    {
        if (Input.GetKeyDown("b"))
        {
            GameManager.current.spawninglight();
        }
        
    }
}

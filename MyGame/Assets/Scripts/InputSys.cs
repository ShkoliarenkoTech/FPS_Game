using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputSys : MonoBehaviour
{
    
    private Rigidbody playerRigidbody;
    private PlayerInput playerInput;



    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();


    }
    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log(context.phase);
            playerRigidbody.AddForce(Vector3.up * 5f, ForceMode.Impulse);
           
        }
    }
}

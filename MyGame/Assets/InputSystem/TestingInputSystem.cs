using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class TestingInputSystem : MonoBehaviour
{
    private Rigidbody thisrigidbody;

    private PlayerInput playerInput;
    private void Awake()
    {
        thisrigidbody = GetComponent<Rigidbody>();

    }
    public void jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("jump" + context.phase);
            thisrigidbody.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }
    }
}

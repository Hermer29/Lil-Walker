using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]
public class KeyboardControl : MonoBehaviour
{
    private Player playerExample;

    private void Start()
    {
        playerExample = GetComponent<Player>();   
    }

    private void FixedUpdate() 
    {
        float verticalMovement = Input.GetAxis("Vertical");
        float horizontalMovement = Input.GetAxis("Horizontal");

        playerExample.Move(horizontalMovement, verticalMovement);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputTest : MonoBehaviour
{

    private Rigidbody cylinderRigidbody;

void Start()
{
    
}


    private void Awake()
    {
        cylinderRigidbody = GetComponent<Rigidbody>();
    }

    public void Jump()
    {
        Debug.Log("Jump");
        cylinderRigidbody.AddForce(Vector3.up * 2f, ForceMode.Impulse);
    }
   
}

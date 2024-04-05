using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class ConveyorTurnController : ConveyorController
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // POLYMORPHISM
    protected override void SetupDirection() {
        direction = (transform.up+-transform.right).normalized;
        Debug.Log(transform.up);
        Debug.Log(-transform.right);
        Debug.Log(direction);
    }
}

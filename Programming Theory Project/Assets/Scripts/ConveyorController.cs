using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class ConveyorController : Building
{
    [SerializeField] private float speed = 1;
    protected Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision collision)
    {
        SetupDirection();
        Rigidbody otherRb = collision.gameObject.GetComponent<Rigidbody>();
        if (otherRb != null)
        {
            otherRb.velocity = direction * speed;
        }
    }

    protected virtual void SetupDirection() {
        direction = transform.up;
    }
}

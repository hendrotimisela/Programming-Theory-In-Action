using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class ConveyorController : Building
{
    [SerializeField] private float speed = 1;
    [SerializeField] private Vector3 direction = new Vector3(0,0,1);

    // Start is called before the first frame update
    void Start()
    {
        direction = direction.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision collision)
    {
        Rigidbody otherRb = collision.gameObject.GetComponent<Rigidbody>();
        if (otherRb != null)
        {
            otherRb.velocity = direction * speed;
        }
    }
}

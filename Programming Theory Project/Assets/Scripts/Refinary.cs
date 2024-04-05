using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refinary : MonoBehaviour
{
    [SerializeField] private float valueModifier = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Ore")) {
            Ore oreInfo = collision.gameObject.GetComponent<Ore>();
            DataManager.Instance.Money = oreInfo.value * valueModifier;
            Destroy(collision.gameObject);
        }
    }
}

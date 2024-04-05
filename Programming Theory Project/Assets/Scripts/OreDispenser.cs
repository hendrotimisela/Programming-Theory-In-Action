using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreDispenser : Building
{
    [SerializeField] private GameObject OrePrefab;
    [SerializeField] private GameObject DispenseObject;
    [SerializeField] private float dispenseRate = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DispenseOres());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DispenseOres() {
        while (true) {
            Instantiate(OrePrefab, DispenseObject.transform.position, OrePrefab.transform.rotation);
            yield return new WaitForSeconds(dispenseRate);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BuyBuildingButton : MonoBehaviour
{
    [SerializeField] private GameObject buildingPrefab;
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(BuyBuilding);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BuyBuilding() {
        if (PlacementController.Instance != null) {
            GameObject building = Instantiate(buildingPrefab);
            PlacementController.Instance.placementObject = building;
            Debug.Log(PlacementController.Instance.placementObject);
        }
    }
}

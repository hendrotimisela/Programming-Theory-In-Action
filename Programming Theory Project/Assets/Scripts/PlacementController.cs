using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementController : MonoBehaviour
{
    public static PlacementController Instance;
    public GameObject placementObject;
    private GameObject previousObject;
    private List<Vector3> hasPlaced = new List<Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (placementObject) {
            Vector3 mousePos = RoundToNearestStep(GetMousePosition3D(), 1);
            Vector3 flattenedMousePos = new Vector3(mousePos.x, 0, mousePos.z);
            placementObject.transform.position = flattenedMousePos;

            if (Input.GetKeyUp(KeyCode.R)) {
                placementObject.transform.Rotate(0,0,90);
            }

            if (Input.GetMouseButtonDown(0) && !hasPlaced.Contains(flattenedMousePos)) {
                hasPlaced.Add(flattenedMousePos);

                ConveyorController conveyorController = placementObject.GetComponent<ConveyorController>();
                ConveyorTurnController conveyorTurnController = placementObject.GetComponent<ConveyorTurnController>();
                OreDispenser oreDispenser = placementObject.GetComponent<OreDispenser>();
                Refinary refinary = placementObject.GetComponent<Refinary>();

                float price = 0;
                if (conveyorController) {
                    conveyorController.placed = true;
                    price = conveyorController.Price;
                } else if (oreDispenser) {
                    oreDispenser.placed = true;
                    price = oreDispenser.Price;
                } else if (conveyorTurnController) {
                    conveyorTurnController.placed = true;
                    price = conveyorTurnController.Price;
                } else if (refinary) {
                    refinary.placed = true;
                    price = refinary.Price;
                }

                DataManager.Instance.Money -= price;
                placementObject = null;
            }
        }
    }

    Vector3 GetMousePosition3D() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            return hit.point;
        }
        return new Vector3(0,0,0);
    }

    // POLYMORPHISM
    Vector3 RoundToNearestStep(Vector3 vector3, float step)
    {
        return new Vector3(RoundToNearestStep(vector3.x, step),RoundToNearestStep(vector3.y, step),RoundToNearestStep(vector3.z, step));
    }

    float RoundToNearestStep(float number, float step)
    {
        return MathF.Round(number / step) * step;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float rotateSpeed = 5f;
    private float RotateX = 0;
    private float RotateY = 45;
    private float Distance = 15;
    private float ScrollSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        UpdateRotation();
        UpdateDistance();
        UpdateCameraTransform();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            UpdateRotation();
        }
        UpdateDistance();
        UpdateCameraTransform();
    }

    void UpdateCameraTransform() {
        Quaternion rotation = Quaternion.Euler(RotateY, RotateX, 0);
        transform.position = target.transform.position - (rotation * Vector3.forward * Distance);

        transform.LookAt(target.transform);
    }

    void UpdateRotation() {
        RotateX += Input.GetAxis("Mouse X") * rotateSpeed;
        RotateY -= Input.GetAxis("Mouse Y") * rotateSpeed;
        RotateY = Mathf.Clamp(RotateY, 5, 89);
    }

    void UpdateDistance() {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Distance -= scroll * ScrollSpeed;
    }
}

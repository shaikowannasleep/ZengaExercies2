using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class RotateQuad : MonoBehaviour
{
    public Camera mainCamera;
    public Transform quad;
    [SerializeField]
    private float rotationSpeed = 1f;
    private bool isDragging = false;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            
            Debug.Log(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && hit.transform == quad)
            {
                isDragging = true;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        if (isDragging && (mouseX != 0f || mouseY != 0f))
        {
            Vector3 mouseDelta = new Vector3(mouseX, mouseY, 1f);
           // float rotateAngle = Vector3.SignedAngle(Vector3.forward, transform.forward, Vector3.up) * rotationSpeed;
            float rotateAngle = Vector3.SignedAngle(Vector3.forward, mouseDelta, Vector3.up) * rotationSpeed;


            RotateQuadObject(rotateAngle);
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 100f, Color.red);
        }
    }

    private void RotateQuadObject(float angle)
    {
        quad.transform.Rotate(mainCamera.transform.forward, angle, Space.World);
    }

}

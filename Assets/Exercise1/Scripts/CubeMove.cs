using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{


    public Camera mainCamera;
    public Transform cube;
    public Transform quad;

    private bool isDragging = false;




    void Update()
    {     
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
           // Debug.Log(Input.mousePosition);
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

        if (isDragging)
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            //Debug.DrawRay(ray.origin, ray.direction * 100f,Color.red);
            if (Physics.Raycast(ray, out hit) && hit.transform == quad)
            {
                cube.position = hit.point - new Vector3(0f, 0f, 0.5f);
            }
        }
    }
}

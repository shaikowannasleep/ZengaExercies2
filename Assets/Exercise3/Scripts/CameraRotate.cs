using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    [SerializeField]
    private float sensitivity = 50f;
    [SerializeField]
    private float minimumX = -60f;
    [SerializeField]
    private float maximumX = 60f;
    [SerializeField]
    private float rotationX = 0;

    private void Start()
    {
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        if (Input.GetMouseButton(0))
        {

            rotationX += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
            rotationX = Mathf.Clamp(rotationX, minimumX, maximumX);

            //Quaternion quaternion = Quaternion.Euler(rotationX, 0, 0);
            Quaternion quaternion = Quaternion.Euler(0, rotationX, 0);
            transform.localRotation = quaternion;

        }
    }
}

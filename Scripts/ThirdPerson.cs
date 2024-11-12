using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPerson : MonoBehaviour
{
    public Transform target;
    public float distance = 0f;
    public float sensitivity = 0f;
    public float heightOffset = 0f;

    private float rotationX = 0f;
    private float rotationY = 0f;
    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void HandleCameraInput()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        rotationY += mouseX;
        rotationX -= mouseY;

        rotationX = Mathf.Clamp(rotationX, -90, 90);

        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0);
    }

    void LateUpdate()
    {
        FollowTarget();
    }

    void FollowTarget()
    {
        Vector3 targetPosition = target.position - target.forward * distance + Vector3.up;
        transform.position = targetPosition;
    }
}

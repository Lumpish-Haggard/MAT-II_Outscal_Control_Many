using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //For Camera movement with mouse
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    //The target object
    public Transform targetObject;

    //Default distance between the target and the player.
    public Vector3 cameraOffset;

    
    //Smoothing factor which we will use for the Camera rotation
    public float smoothFactor = 0.5f;

    //This will check if the camera looks at the target or not.
    public bool lookAtTarget=false;

    // Start is called before the first frame update
    void Start()
    { 
        cameraOffset = transform.position - targetObject.transform.position;       
    }
 
    // Update is called once per frame
    void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        yaw = Mathf.Clamp(yaw, -90f, 90f);
        //the rotation range
        pitch = Mathf.Clamp(pitch, -60f, 90f);
        //the rotation range

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPosition=targetObject.transform.position+cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPosition, smoothFactor);
        //Camera Rotation Change
        if (lookAtTarget) 
        {
        transform.LookAt(targetObject);
        }

    }

}
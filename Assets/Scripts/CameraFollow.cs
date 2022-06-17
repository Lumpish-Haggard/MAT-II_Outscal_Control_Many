using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
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
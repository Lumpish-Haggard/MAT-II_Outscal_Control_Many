using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAI : MonoBehaviour
{
    public Transform target;
    public Transform Follower;
    public float speed = 2.0f;


    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);   
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}

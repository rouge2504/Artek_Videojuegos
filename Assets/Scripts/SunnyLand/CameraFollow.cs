using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate()
    {
        Vector3 desirePosition = target.position + offset;
        Vector3 position = Vector3.Lerp(transform.position, desirePosition, smoothSpeed);
        transform.position = new Vector3(position.x, position.y, this.transform.position.z); //2D
                                                                                                //transform.position = position; //3D
                                                                                                //transform.LookAt(target);

    }

}

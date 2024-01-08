using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform target; // The player's transform
    public float smoothSpeed = 0.4f; // The speed at which the camera follows the player
    public Vector3 offset;

    private void Update()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        //transform.position = Vector3.Lerp(transform.position, Vector3.forward * player.height, smoothSpeed);
        //transform.LookAt(target);
    }
}
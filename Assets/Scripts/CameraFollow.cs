using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject mainPlayer;
    public float timeOffSet;
    public Vector3 posOffSet;

    private Vector3 velocity;

    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, mainPlayer.transform.position + posOffSet, ref velocity, timeOffSet);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform birdTransform;
    Vector3 range;
    void Awake ()
    {
        range = transform.position - birdTransform.position;
    }
    void fixedUpdate ()
    {
    transform.position = new Vector3( range.x + birdTransform.position.x, transform.position.y, range.z + birdTransform.position.z);
    }
void OnTriggerExit2D(Collider2D other)
    {
		Debug.Log("The object left the trigger collision");
    }
}


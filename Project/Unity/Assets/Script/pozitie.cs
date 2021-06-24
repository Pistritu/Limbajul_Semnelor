using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pozitie : MonoBehaviour
{
    public Transform target;
    public float preferredDistance = 5.0f;
    // Use this for initialization
    void Start () {
        //Considering this object is the source object to move
        PlaceObject ();
    }

    void PlaceObject(){
        Vector3 distanceVector = transform.position - target.position ;
        Vector3 distanceVectorNormalized = distanceVector.normalized;
        Vector3 targetPosition = (distanceVectorNormalized * preferredDistance);
        transform.position = targetPosition;
    }
}
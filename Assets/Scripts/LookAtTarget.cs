using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    //the target that we are going to focus on
    public Transform target;



    // Update is called once per frame
    void Update()
    {
        //Calculate relative position between this object and target
        Vector3 relativePos = target.position - transform.position;
        //Project position to the xz plane
        Vector3 relativePosXZ = Vector3.ProjectOnPlane(relativePos, Vector3.up);

        //Create a look rotation
        Quaternion lookRotation = Quaternion.LookRotation(relativePosXZ);

        //apply this rotation to gameobject
        transform.rotation = lookRotation;
    }
}

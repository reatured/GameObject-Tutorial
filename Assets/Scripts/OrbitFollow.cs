using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitFollow : MonoBehaviour
{
    public Transform target;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = target.position + new Vector3(0, 2f, 0) - transform.position;

        Quaternion lookRot = Quaternion.LookRotation(relativePos);

        Quaternion current = transform.rotation;

        Debug.DrawRay(transform.position, relativePos, Color.green);

        transform.localRotation = Quaternion.Slerp(current, lookRot, Time.deltaTime);

        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));

        Debug.DrawRay(transform.position, new Vector3(0, 0, speed * Time.deltaTime * 100), Color.yellow);
    }
}

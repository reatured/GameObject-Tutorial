using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [Header("Platform movement parameter")]
    [Tooltip("Parameters that control the movement of platform")]
    [SerializeField]
    private float movementSpeed;
    [SerializeField]
    private float movementDistance;
    [SerializeField]
    private Vector3 movementAxis;

    [SerializeField]
    private Vector3 startPos;
    private Vector3 posEnd, negEnd;

    private Vector3 direction;


    // Start is called before the first frame update
    void Start()
    {
        direction = movementAxis.normalized;
        startPos = transform.position;
        posEnd = startPos + (direction * movementDistance);
        negEnd = startPos - (direction * movementDistance);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Vector3.Distance(transform.position, posEnd)<0.01f || Vector3.Distance(transform.position, negEnd) < 0.01f)
        {
            direction *= -1;

        }

        transform.Translate(direction * movementSpeed * Time.deltaTime);
    }
}

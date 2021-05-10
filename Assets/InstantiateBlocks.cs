using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBlocks : MonoBehaviour
{
    [Header("Activate objects")]
    public GameObject targetObject;
    // Start is called before the first frame update
    void Start()
    {
        targetObject.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            targetObject.SetActive(true);
            Destroy(this.gameObject);

        }
    }
}

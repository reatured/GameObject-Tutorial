using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    public int counter;

    //prefab to be instantiated
    public GameObject bonusObject;

    // Start is called before the first frame update
    void Start()
    {
        counter = GameObject.FindGameObjectsWithTag("Pick Up").Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pickup()
    {
        counter--;

        if(counter == 0)
        {
            SpawnBonus();
        }
        
    }

    void SpawnBonus()
    {
        GameObject.Instantiate(bonusObject, transform);

    }
}

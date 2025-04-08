using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tenemy : Enemy
{
    public GameObject targettower;
    // Start is called before the first frame update
    void Start()
    {
        targettower = GameObject.FindWithTag("Tower");
    }

    // Update is called once per frame
    void Update()
    {
        DisplayHealth();
        manager = FindObjectOfType<GameManager>();
        thisObject.transform.position += VectorToTower() * speed;
    }

    Vector3 VectorToTower() 
    {
        Vector3 targetdirection;
        targetdirection = targettower.transform.position - transform.position;
        targetdirection = targetdirection.normalized;
        return targetdirection;
    }

}

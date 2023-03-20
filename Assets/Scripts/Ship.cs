using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ship : MonoBehaviour
{
    public GameObject bottlePrefab;
    public float speedShip = 14f;
    public float borderLeftAndRight = 116f;
    public float chanceToChangeDirections = 0.02f;

    void Start()
    {
        Invoke("DropBottle", 2f);
    }

    void DropBottle()
    {
        GameObject bottle = Instantiate<GameObject>(bottlePrefab);
        bottle.transform.position = transform.position;
        Invoke("DropBottle", 1f);
    }

    void Update()
    {
        Vector3 positionShip = transform.position;
        positionShip.x += speedShip * Time.deltaTime;
        transform.position = positionShip;

        if (positionShip.x > borderLeftAndRight)
        {
            speedShip = -Mathf.Abs(speedShip);
        }
        else if (positionShip.x < -borderLeftAndRight)
        {
            speedShip = Mathf.Abs(speedShip);
        }
    }
    void FixedUpdate()
    {
        if (UnityEngine.Random.value < chanceToChangeDirections)
        {
            speedShip *= -1;
        }
    }
}

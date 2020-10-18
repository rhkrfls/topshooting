﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bullet_Prefab;

    private float bullet_Time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + new Vector3(-0.1f, 0);
            print("Left arrow key is held down");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(0.1f, 0);
            print("Right arrow key is held down");
        }

        if (bullet_Time++ > 25)
        {
            var bullet_Object = Instantiate(bullet_Prefab);
            bullet_Object.transform.position = transform.position;

            bullet_Time = 0;
        }
    }
}

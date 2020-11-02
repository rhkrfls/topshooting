﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CollisionObject
{
    public GameObject bullet_Prefab;
    public int bullet_Term = 10;

    private int bullet_Term_Count = 0;
    private float defaultY;

    void Start()
    {
        defaultY = transform.position.y;
    }

    protected override void Update()
    {
        base.Update();

        MovementVector = Vector2.zero;

        if(Input.GetMouseButton(0))
        {
            var worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var diff = worldPosition.x - transform.position.x;

            if (Mathf.Abs(diff) < 0.05f)
                transform.position = new Vector3(worldPosition.x, defaultY, 0);

            else
                MovementVector = new Vector2(diff / 5, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + new Vector3(-0.1f, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(0.1f, 0);
        }

        if (bullet_Term_Count++ > bullet_Term)
        {
            Fire();

            bullet_Term_Count = 0;
        }
    }

    private void Fire()
    {
        var bullet_Object = Instantiate(bullet_Prefab);
        bullet_Object.transform.position = transform.position;
    }

    protected override void OnCollisionEnter(Collision collision)
    {
    }

}

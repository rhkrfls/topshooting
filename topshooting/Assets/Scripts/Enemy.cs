using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : CollisionObject
{
   // [SerializeField] //private 변수도 Inspector에 나오게 됨
    private int HP = 1;

    void Start()
    {
        MovementVector = new Vector2(0, -0.1f);
    }

    protected override void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Player>() != null)
        {
            Destroy(collision.gameObject);
        }
    }

    public void DecreaseHP(int value = 1)
    {
        HP -= value;

        if(HP == 0)
        {
            Destroy(gameObject);
        }
    }
}

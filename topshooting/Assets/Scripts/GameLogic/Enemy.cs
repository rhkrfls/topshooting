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
            var destroyEffectPrefab = Resources.Load("Prefabs/Explosion") as GameObject;
            var destroyEffect = Instantiate(destroyEffectPrefab, transform);
            GetComponent<BoxCollider>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;

            GameHUD.Instance.AddScore(10);
            Invoke("DestroySelf", 1.0f);
        }
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}

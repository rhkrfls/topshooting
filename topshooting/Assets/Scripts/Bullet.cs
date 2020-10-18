using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0, 0.1f);

        //if(transform.position.y >= 8.0f)
        //{
        //    Destroy(gameObject);
        //}
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);

        if(collision.gameObject.name == "Wall")
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Function : MonoBehaviour
{
    private float destroy_timer = 1f;

    // Update is called once per frame
    void Update()
    {
        destroy_timer -= Time.deltaTime;

        if (destroy_timer <= 0)
            Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("NormalEnemy"))
            Destroy(collision.gameObject);
        else if (collision.gameObject.CompareTag("EliteEnemy"))
            Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}


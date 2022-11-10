using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAuraFunction : MonoBehaviour
{
    float destroy_timer = 2f;

    // Start is called before the first frame update
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
    }
}

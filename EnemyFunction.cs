using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFunction : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Weapon"))
            Destroy(gameObject);
        else if (collision.gameObject.CompareTag("AliveZone"))
            Destroy(gameObject);
    }
}

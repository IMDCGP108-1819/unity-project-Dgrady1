using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour {

    public int health = 1;

    public float invulnPeriod = 0;

    float invunrabilityTimer = 0;
    int correctLayer;

    void Start()
    {
        correctLayer = gameObject.layer;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger");
        if (invunrabilityTimer <= 0)
        {
            health--;
            invunrabilityTimer = 1f;

            gameObject.layer = 10;
        }
    }
    void Update()
    {
        invunrabilityTimer -= Time.deltaTime;
        if (invunrabilityTimer <= 0)
        {
            gameObject.layer = correctLayer;
        }
        if (health <= 0)
        {
            Death();
        }
    }
    void Death()
    {
        Destroy(gameObject);
    }

}


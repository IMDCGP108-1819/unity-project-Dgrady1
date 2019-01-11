using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public GameObject BulletPrefab;

    public float delay = 0.25f;
    float bulletTimer = 0;

	// Update is called once per frame
	void Update () {
        bulletTimer -= Time.deltaTime;

        if(Input.GetButton("Fire1") && bulletTimer <= 0)
        {
            //shoot
            bulletTimer = delay;

            Instantiate(BulletPrefab, transform.position, transform.rotation);
        }
	}
}

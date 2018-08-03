using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, -speed * Time.deltaTime);

        if (transform.position.z > 5)
        {
            Destroy(gameObject);
        }
    }
}

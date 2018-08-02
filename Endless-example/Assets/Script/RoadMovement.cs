using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMovement : MonoBehaviour {

    public float moveSpeed;
    public float limit;
    public float roadSize;
    public GameObject furthestRoad;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, moveSpeed * Time.deltaTime);

        if (transform.position.z > limit)
        {
            Vector3 newPosition = furthestRoad.transform.position;
            newPosition.z -= roadSize;
            transform.position = newPosition;
        }
    }
}

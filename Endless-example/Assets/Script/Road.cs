using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour {

    public float m_MoveSpeed;
    public float roadChangeMaxPosition;
    public float roadNewPosition;
    public GameObject AnotherRoad;
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0f, 0f , m_MoveSpeed * Time.deltaTime);
        if (transform.position.z > roadChangeMaxPosition)
        {
            Vector3 newPosition = AnotherRoad.transform.position;
            newPosition.z -= roadNewPosition;
            transform.position = newPosition;
        }
    }
}

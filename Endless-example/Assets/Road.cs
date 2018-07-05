using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour {

    public float m_MoveSpeed;

    public GameObject AnotherRoad;
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0f, 0f , m_MoveSpeed * Time.deltaTime);
        if (transform.position.z > 25)
        {
            Vector3 newPosition = AnotherRoad.transform.position;
            newPosition.z -= 40;
            transform.position = newPosition;
        }
    }
}

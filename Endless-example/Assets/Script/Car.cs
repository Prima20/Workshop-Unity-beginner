using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

    public float m_Speed;
    public float Minx, MaxX;

    private Rigidbody m_rbd;

	// Use this for initialization
	void Start () {
        m_rbd = GetComponent<Rigidbody>();
	}

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
        m_rbd.velocity = movement * m_Speed;

        m_rbd.position = new Vector3(Mathf.Clamp(m_rbd.position.x, Minx, MaxX), m_rbd.position.y, 0.0f);

    }
}

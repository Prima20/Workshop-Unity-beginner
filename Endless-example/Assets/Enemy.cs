using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float m_MoveSpeed;
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0f, 0f, m_MoveSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Lose");
        }
    }
}

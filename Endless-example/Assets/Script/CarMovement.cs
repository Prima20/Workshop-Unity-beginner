using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarMovement : MonoBehaviour {

	public float speed;
    public float MinX, MaxX;

    private Rigidbody rbd;

    public string SceneName;

    // Use this for initialization
    void Start()
    {
        rbd = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float direction = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(-direction, 0.0f, 0.0f);
        rbd.velocity = movement * speed;

        rbd.position = new Vector3(Mathf.Clamp(rbd.position.x, MinX, MaxX), rbd.position.y, rbd.position.z);

    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}

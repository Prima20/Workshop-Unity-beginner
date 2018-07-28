using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

    public GameObject[] Enemy;
	
	// Update is called once per frame
	void Start () {
        InvokeRepeating("GenerateEnemy", 1f, 3f);
	}

    void GenerateEnemy()
    {
        Vector3 position = new Vector3(Random.Range(-3, 4), -0.55f, -28);
        Instantiate(Enemy[Random.Range(0, Enemy.Length)], position, Quaternion.Euler(0,180,0));
    }
}

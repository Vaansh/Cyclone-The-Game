using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public float spawnRate = 1f;

    public GameObject hexagonPrefab;

    private float nextTimeToSpawn = 1f;
	
	// Update is called once per frame
	void Update () {
		if(Time.time >= nextTimeToSpawn)
        {
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	[SerializeField] private GameObject playerPrefab = null;
	[SerializeField] private GameObject obstaclePrefab = null;
	[SerializeField] private float spawnInterval = 2.5f;
	
	void Start(){
		//  Oppretter et player-objekt
		SpawnPlayer();
		// Oppretter et obstacle-objekt hvert spawnInterval*sekund
		InvokeRepeating("SpawnObstacle", 0f, spawnInterval);
	}

	// Oppretter en instans av typen playerPrefab
	void SpawnPlayer(){
		Instantiate(playerPrefab, new Vector3(-2f, 0f, 0f), Quaternion.identity);
	}
	// Oppretter en instans av typen obstaclePrefab
	void SpawnObstacle(){
		Vector3 spawnPos = new Vector3(14f, 0f, 0f);
		Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
	}

}

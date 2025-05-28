// System
	using System;
	using System.Collections;
	using System.Collections.Generic;
	
// Unity
	using UnityEngine;
	using UnityEngine.UI;

	// Project
// Alias

/// <summary>
/// 클래스 설명을 적는 곳 입니다.
/// <summary>
public class SpawnManager : MonoBehaviour
{
 	public Transform[] spawnPoints;
	public PlayerController player;
    public GameObject prefab;
	
    public Text text;
    
    public float timer;
    public float coolDown = 2.0f;

    void Start()
    {
	    text.gameObject.SetActive(false);
	    spawn();
    }
    
    void Update()
    {
	    timer += Time.deltaTime;
    }

    void spawn()
    {
	    if (player.Hit)
	    {
		    text.gameObject.SetActive(true);
		    return;
	    }
	    StartCoroutine(ISpawnCooldown());
    }

    IEnumerator ISpawnCooldown()
    {
	    int ranNum = UnityEngine.Random.Range(0, spawnPoints.Length); 
	    yield return new WaitForSeconds(coolDown);
	    Instantiate(prefab, spawnPoints[ranNum].position, Quaternion.identity);
	    spawn();
    } 
}

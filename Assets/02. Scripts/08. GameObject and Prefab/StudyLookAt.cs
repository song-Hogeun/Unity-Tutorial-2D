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
public class StudyLookAt : MonoBehaviour
{
	public Transform targetTF;
	public Transform towerHead;

	public GameObject bulletPrefab;
	public Transform[] firePos;

	public float timer;
	public float cooldownTime;
	void Start()
	{
		targetTF = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	void Update()
	{
		transform.LookAt(targetTF);
		
		timer += Time.deltaTime;
		if (timer >= cooldownTime)
		{
			timer = 0f;
			for(int i = 0; i < firePos.Length; i++)
			{
				Instantiate(bulletPrefab, firePos[i].position, firePos[i].rotation);
			}
		}
	}
}

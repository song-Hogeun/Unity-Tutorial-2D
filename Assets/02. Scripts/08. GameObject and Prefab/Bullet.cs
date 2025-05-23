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
public class Bullet : MonoBehaviour
{
	public float bulletSpeed = 100f;
    
	void Update()
	{
		transform.position += transform.forward * bulletSpeed * Time.deltaTime;
	}
}

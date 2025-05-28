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
public class Ball : MonoBehaviour
{
	public float moveSpeed = 1.2f;
	void Update()
	{
		transform.position += Vector3.down * moveSpeed * Time.deltaTime;
	}

	void OnCollisionEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Plane" || coll.gameObject.tag == "Player")
		{
			Destroy(this.gameObject);
		}
	}
}

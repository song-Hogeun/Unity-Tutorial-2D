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
public class PlayerController : MonoBehaviour
{
	private float moveSpeed = 3.0f;
	private Rigidbody2D rb;
	public bool Hit = false;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	void Update()
	{
		float h = Input.GetAxis("Horizontal");
		
		rb.linearVelocityX = h * moveSpeed;
	}

	private void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Ball")
		{
			Hit = true;
			moveSpeed = 0f;
		}
	}
}

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
public class CarMovement : MonoBehaviour
{
	public float moveSpeed = 3f;
	
	public Rigidbody2D rb;

	void FixedUpdate() 
	{
		float h = Input.GetAxis("Horizontal");
		
		rb.linearVelocityX = h * moveSpeed;
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		Debug.Log(coll.gameObject.name);
	}
}

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
public class CatController : MonoBehaviour
{
	public float jumpPower = 10.0f;
	public bool isGround;
	private Rigidbody2D rb;

	public int jumpCount;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 2)
		{
			rb.AddForceY(jumpPower, ForceMode2D.Impulse);
			jumpCount++;
		}
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.collider.CompareTag("Ground"))
		{
			isGround = true;
			jumpCount = 0;
		}
	}

	void OnCollisionExit2D(Collision2D other)
	{
		if (other.collider.CompareTag("Ground"))
		{
			isGround = false;
		}
	}
}

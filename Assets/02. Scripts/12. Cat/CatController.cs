// System
	using System;
	using System.Collections;
	using System.Collections.Generic;
	
// Unity
	using UnityEngine;
	using UnityEngine.UI;

// Project
	using Cat;
// Alias

/// <summary>
/// 클래스 설명을 적는 곳 입니다.
/// <summary>
public class CatController : MonoBehaviour
{
	public GameManager gameManager;
	public SoundManager soundManager;	
	
	private Rigidbody2D catRb;
	private Animator catAnim;
	
	public float jumpPower = 11.0f;
	public float limitPower = 10f;
	public bool isGround;
	
	public int jumpCount;

	void Start()
	{
		catRb = GetComponent<Rigidbody2D>();
		catAnim = GetComponent<Animator>();
	}
	void Update()
	{
		if (!gameManager.isReady || gameManager.gameOver)
			return;
		
		if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 10)
		{
			catAnim.SetTrigger("Jump");
			catAnim.SetBool("isGround", false);
			jumpCount++; // 1씩 증가
			soundManager.OnJumpSound();
			catRb.AddForceY(jumpPower, ForceMode2D.Impulse);

			if (catRb.linearVelocityY > limitPower) // 자연스러운 점프를 위한 속도 제한
				catRb.linearVelocityY = limitPower;
		}

		var catRotation = transform.eulerAngles;
		catRotation.z = catRb.linearVelocityY * 5f;
		transform.eulerAngles = catRotation;
	}
	
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Apple"))
		{
			other.gameObject.SetActive(false);
			other.transform.parent.GetComponent<ItemEvent>().particle.SetActive(true);
			
			GameManager.score++;
		}
	}
	
	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.collider.CompareTag("Pipe"))
		{
			soundManager.OnCollisionSound();
			gameManager.GameEnd();
		}
		
		if (other.collider.CompareTag("Ground"))
		{
			isGround = true;
			catAnim.SetBool("isGround", isGround);
			jumpCount = 0;
		}
	}
}
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
public class ColliderEvent : MonoBehaviour
{
	public GameManager gameManager;
	public SoundManager soundManager;
	
	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			soundManager.OnCollisionSound();
			gameManager.gameOver = true;
		}
	}
}

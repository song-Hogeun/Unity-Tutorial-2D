// System
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Cat;

	// Unity
	using UnityEngine;
	using UnityEngine.UI;

// Project
// Alias

/// <summary>
/// 클래스 설명을 적는 곳 입니다.
/// <summary>
public class ItemEvent : MonoBehaviour
{
	public enum ColliderType { Pipe, Apple, Both }
	public ColliderType colliderType;
	
	public GameManager gameManager;

	public GameObject pipe;
	public GameObject apple;
	public GameObject particle;
	
	public float moveSpeed = 3f;
	public float returnPosX = 15f;

	public float randomPosY;
	// 배경 이미지의 길이가 30이기 때문에 x = 30f

	private void Start()
	{
		SetRandomSetting(transform.position.x);
	}

	void Update()
	{
		if(!gameManager.isReady || gameManager.gameOver)
		{
			transform.position = this.transform.position;
		}
		
		else if (gameManager.isReady)
		{
			transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime;

			if (transform.position.x <= -returnPosX)	// 이미지의 x축 값이 -30을 넘는 순간
			{
				SetRandomSetting(returnPosX);
			}
		}
	}

	void SetRandomSetting(float posX)
	{
		randomPosY = UnityEngine.Random.Range(-8f, -2.5f);
		transform.position = new Vector3(posX, randomPosY, 0.1f);
		
		pipe.SetActive(false);
		apple.SetActive(false);
		particle.SetActive(false);
		
		colliderType = (ColliderType)UnityEngine.Random.Range(0, 3);
		
		switch (colliderType)
		{
			case ColliderType.Pipe:
				pipe.SetActive(true);
				apple.SetActive(false);
				break;
			
			case ColliderType.Apple:
				pipe.SetActive(false);
				apple.SetActive(true);
				break;
			
			case ColliderType.Both:
				pipe.SetActive(true);
				apple.SetActive(true);
				break;
		}
	}
}

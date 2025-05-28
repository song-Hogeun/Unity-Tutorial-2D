// System
	using System;
	using System.Collections;
	using System.Collections.Generic;
	
// Unity
	using UnityEngine;
	using UnityEngine.UI;
	using Random = System.Random;

	// Project
// Alias

/// <summary>
/// 클래스 설명을 적는 곳 입니다.
/// <summary>
public class Transform_LoopMap : MonoBehaviour
{
	public float moveSpeed = 3f;
	public float returnPosX = 15f;

	public float randomPosY;
	// 배경 이미지의 길이가 30이기 때문에 x = 30f

	void Update()
	{
		// 배경 왼쪽으로 이동하는 기능
		transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime;

		if (transform.position.x <= -returnPosX)	// 이미지의 x축 값이 -30을 넘는 순간
		{
			randomPosY = UnityEngine.Random.Range(-8f, -2.5f);
			transform.position = new Vector3(returnPosX, randomPosY, 0.1f);		// 다시 사용하기 위해서 오른쪽 x = 30으로
		}
	}
}

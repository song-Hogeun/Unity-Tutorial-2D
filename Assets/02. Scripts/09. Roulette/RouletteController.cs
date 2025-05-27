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
public class RouletteController : MonoBehaviour
{
	public float rotSpeed;

	public bool isStop;

	private void Start()
	{
		rotSpeed = 0f;
	}

	private void Update()
	{
		transform.Rotate(Vector3.forward * rotSpeed);	// Z 축 기준으로 회전하는 기능
		
		// 마우스 왼쪽 버튼을 눌렀을 때 회전하는 기능 -> 1번 실행
		if (Input.GetMouseButtonDown(0))
		{
			rotSpeed = 5f;
		}
		
		// 키보드 스페이스 버튼을 눌렀을 때 -> 1번 실행
		if (Input.GetKeyDown(KeyCode.Space))
		{
			isStop = true;
		}
		
		if(isStop)
		{
			rotSpeed -= 0.5f * Time.deltaTime;	// 현재 속도에서 특정 값만큼 줄인다.
			if (rotSpeed <= 0.01f)
			{
				rotSpeed = 0f;
				isStop = false;
			}
		}	
	}
}

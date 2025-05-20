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
/// 어몽어스 캐릭터의 이동 관련 코드를 작성하는 스크립트 입니다.
/// <summary>
public class Movement : MonoBehaviour
{
	public float moveSpeed; // 이동속도
    
	void start()
	{
		
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.W))	// 앞으로 가는 기능
		{
			this.transform.position += Vector3.forward * moveSpeed * Time.deltaTime;	
		}
		if (Input.GetKey(KeyCode.A))	// 왼쪽으로 가는 기능
		{
			this.transform.position += Vector3.left * moveSpeed * Time.deltaTime;	
		}
		if (Input.GetKey(KeyCode.S))	// 뒤로 가는 기능
		{
			this.transform.position += Vector3.back * moveSpeed * Time.deltaTime;	
		}
		if (Input.GetKey(KeyCode.D))	// 오른쪽으로 가는 기능
		{
			this.transform.position += Vector3.right * moveSpeed * Time.deltaTime;	
		}
	}
}

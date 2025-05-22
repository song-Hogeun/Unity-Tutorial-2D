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
	public float moveSpeed = 5f;
     
	void Update()
	{
		/// Input System (Old - Legacy)
		/// 입력값에 대한 약속된 시스템
		/// 이동 -> WASD, 화살표키보드
		/// 점프 -> Space
		/// 총쏘기 -> 마우스 왼쪽
         
		float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw("Vertical");
         
		Vector3 dir = new Vector3(h, 0, v);
		Debug.Log($"현재 입력 : {dir}");
         
		transform.position += dir * moveSpeed * Time.deltaTime;
	}
}

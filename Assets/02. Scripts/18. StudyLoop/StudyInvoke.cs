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
public class StudyInvoke : MonoBehaviour
{
	public int count = 10;
	void Start()
	{
		// 반복 Invoke ("함수명", 처음 지연시간, 몇초마다 실행)
		InvokeRepeating("Bomb", 0f, 1f);
	}

	private void Bomb()
	{
		Debug.Log($"현재 남은 시간 : {count} 초");
		
		if (count <= 0)
		{
			Debug.Log("폭탄이 터졌습니다.");
			CancelInvoke("Bomb");
		}
		
		count--;
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			CancelInvoke("Bomb");
			Debug.Log("폭탄이 해제되었습니다.");
		}
	}
}

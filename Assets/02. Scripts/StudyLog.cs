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
/// 유니티 에디터에 있는 Console View에 Log를 테스트하기 위한 클래스
/// <summary>
public class StudyLog : MonoBehaviour
{
	void Start()
	{
		Debug.Log("Start 함수 실행");
		Debug.LogWarning("Start 함수 실행");
		Debug.LogError("Start 함수 실행");
	}

	void Update()
	{
		
	}
}

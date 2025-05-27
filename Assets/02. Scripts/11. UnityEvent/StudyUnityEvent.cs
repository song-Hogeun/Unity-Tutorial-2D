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
public class StudyUnityEvent : MonoBehaviour
{
	private void Awake()
	{
		Debug.Log("Awake");
	}

	private void Start()
	{
		Debug.Log("Start");
	}

	private void OnEnable()
	{
		Debug.Log("OnEnable");
	}

	private void Update()
	{
		Debug.Log("Update");
	}

	private void OnDisable()
	{
		Debug.Log("OnDisable");
	}
}

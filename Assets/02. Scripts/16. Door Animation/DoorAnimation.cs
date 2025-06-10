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
public class DoorAnimation : MonoBehaviour
{
	private Animator animator;

	void Start()
	{
		animator = GetComponent<Animator>();
	}

	private void OnTriggerEnter(Collider other)
	{
		animator.SetTrigger("Open");
	}

	void OnTriggerExit(Collider other)
	{
		animator.SetTrigger("Close");
	}
}

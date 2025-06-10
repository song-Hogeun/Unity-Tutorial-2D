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
public class DoorAnimation2 : MonoBehaviour
{
	public GameObject doorLock;

	private void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Player"))
		{
			doorLock.SetActive(true);
		}
	}

	void OnTriggerExit(Collider other)
	{
		if(other.CompareTag("Player"))
		{
			doorLock.SetActive(false);
		}
	}
}

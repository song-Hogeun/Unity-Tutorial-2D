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
public class CatFollow : MonoBehaviour
{
	public Transform cat;
	public Vector3 offset;

	void Update()
	{
		transform.position = cat.position + offset;
	}
}

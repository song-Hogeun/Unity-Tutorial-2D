// System
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEditor.Rendering;

	// Unity
	using UnityEngine;
	using UnityEngine.UI;

// Project
// Alias

/// <summary>
/// 클래스 설명을 적는 곳 입니다.
/// <summary>
public class StudyFor : MonoBehaviour
{
	void Start()
	{
		for (int i = 0; i < 3; i++)
		{
			for (int j = 0; j < 3; j++)
			{
				Debug.Log($"{i}, {j}");
			}
		}		
	}
}

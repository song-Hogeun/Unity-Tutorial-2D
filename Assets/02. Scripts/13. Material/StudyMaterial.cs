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
public class StudyMaterial : MonoBehaviour
{
	public Material mat;
	public string hexCode;
	
	private void Start()
	{
		// GetComponent<MeshRenderer>().material = mat;
		
		// this.GetComponent<MeshRenderer>().sharedMaterial = mat;
		
		// GetComponent<MeshRenderer>().material.color = Color.green;
		
		// GetComponent<MeshRenderer>().sharedMaterial.color = Color.green;

		mat = GetComponent<MeshRenderer>().material;
		Color outputColor = mat.color;

		if (ColorUtility.TryParseHtmlString(hexCode, out outputColor))
		{
			mat.color = outputColor;
		}
	}
}

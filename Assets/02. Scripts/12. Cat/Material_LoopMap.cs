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
public class Material_LoopMap : MonoBehaviour
{
	MeshRenderer renderer;
	public float offsetSpeed = 0.1f;
	
	void Start()
	{
		renderer = GetComponent<MeshRenderer>();
	}

	void Update()
	{
		Vector2 offset = Vector3.right * offsetSpeed * Time.deltaTime;	
		
		renderer.material.SetTextureOffset("_MainTex", renderer.material.mainTextureOffset + offset);
	}
}

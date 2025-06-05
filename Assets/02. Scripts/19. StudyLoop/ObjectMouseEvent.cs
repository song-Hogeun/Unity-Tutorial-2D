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
public class ObjectMouseEvent : MonoBehaviour
{
	void OnMouseDown()
	{
		Debug.Log("Mouse Down");
	}

	void OnMouseUp()
	{
		Debug.Log("Mouse Up");
	}

	void OnMouseEnter()
	{
		Debug.Log("Mouse Enter");
	}

	void OnMouseExit()
	{
		Debug.Log("Mouse Exit");
	}

	void OnMouseUpAsButton()
	{
		Debug.Log("Mouse UpAsButton");
	}

	void OnMouseDrag()
	{
		Debug.Log("Mouse Drag");
	}

	void OnMouseOver()
	{
		Debug.Log("Mouse Over");
	}
}

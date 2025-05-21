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
/// 
public class StudyComponent : MonoBehaviour
{
    public GameObject obj;  // 큐브 게임 오브젝트를 가져오고 싶다.

    public string changeName;
    
    void Start()
    {
        obj = GameObject.Find("Main Camera");
        
        obj.name = changeName;
    }
}
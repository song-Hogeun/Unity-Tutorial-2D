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
public class StudyArray : MonoBehaviour
{
    [SerializeField] private List<int> listNumber = new List<int>();
    
    private void Start()
    {
        listNumber.Add(10);
        listNumber.Add(22);
        listNumber.Add(35);
        listNumber.Add(41);
        listNumber.Add(59);
        
        Debug.Log($"현재 List에 있는 데이터 수 : {listNumber.Count}");
        Debug.Log($"현재 List의 마지막 데이터 : {listNumber[listNumber.Count - 1]}");
    }
}
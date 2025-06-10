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
public class CharacterMovement : MonoBehaviour
{
	public float moveSpeed;
	public float jumpForce;
	public float dashPower;
	public float rotSpeed;
	
	public bool isRun;
	public bool isGround;

	private float h;

	public Transform spawnPoint;
	public GameObject knife;
	
	Rigidbody2D rb;
	SpriteRenderer sr;
	Animator anim;

	void Start()
	{
		sr = GetComponent<SpriteRenderer>();
		anim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		Skill();
		Jump();
		spawnPoint.Rotate(new Vector3(0, 1f * rotSpeed, 0));
	}
	
	void FixedUpdate()
	{
		Move();
		Dash();
	}

	void Move()
	{
		h = Input.GetAxisRaw("Horizontal");
		
		if(h < 0)
		{
			sr.flipX = true;
			anim.SetFloat("Blend", 1f);
		}
		
		else if(h > 0)
		{
			sr.flipX = false;
			anim.SetFloat("Blend", 1f);
		}
		
		else
		{
			anim.SetFloat("Blend", 0f);
		}
		
		rb.linearVelocityX = h * moveSpeed;
	}

	void Jump()
	{
		if(Input.GetButtonDown("Jump") && isGround)
		{
			rb.AddForceY(jumpForce, ForceMode2D.Impulse);
			anim.SetTrigger("Jump");
		}
	}

	void Skill()
	{
		if (Input.GetKeyDown(KeyCode.Q))
		{
			GameObject obj1 = Instantiate(knife, spawnPoint.position + new Vector3(1.5f, 0, 0), Quaternion.identity);
			obj1.transform.SetParent(spawnPoint.transform);
			obj1.transform.rotation = Quaternion.Euler(0, 0, 180f);
			
			GameObject obj2 = Instantiate(knife,spawnPoint.position + new Vector3(-1.5f, 0, 0), Quaternion.identity);
			obj2.transform.SetParent(spawnPoint.transform);
			obj2.transform.rotation = Quaternion.Euler(0, 0, 180f);
		}
	}

	void Dash()
	{
		if (Input.GetKey(KeyCode.LeftShift))
		{
			rb.linearVelocityX = h * dashPower;
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.CompareTag("Plane"))
		{
			isGround = true;
		}
	}

	void OnCollisionExit2D(Collision2D other)
	{
		if (other.gameObject.CompareTag("Plane"))
		{
			isGround = false;
		}
	}
}

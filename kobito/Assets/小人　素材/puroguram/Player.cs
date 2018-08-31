﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    Rigidbody2D jyuuryoku;
    float idou = 0f;
    float jyunp = 400;
    float jyunpdown2 = 0;
    float jyunpdown = 0;
    float a = 0;
    float b = 0;
    float c = 1;
    float d = 0;
    float e = 0;
    float m = 0.3f;
    Vector3 muki;
    Animator anime;
    // Use this for initialization
    void Start () {
        this.jyuuryoku = GetComponent<Rigidbody2D>();
        this.anime = GetComponent<Animator>();
        this.muki = new Vector3();
	}
	
	// Update is called once per frame
	void Update () {
        this.b += Time.deltaTime;
        this.d += Time.deltaTime;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.idou = 10;
            this.jyuuryoku.AddForce(transform.right * this.idou);
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            this.idou = 0;
            this.jyuuryoku.AddForce(transform.right * this.idou);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.idou = 10;
            this.jyuuryoku.AddForce(transform.right * -1 * this.idou);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if(Input.GetKeyUp(KeyCode.LeftArrow))
        {
            this.idou = 0;
            this.jyuuryoku.AddForce(transform.right * this.idou);
        }

        if (Input.GetKeyDown(KeyCode.Space) && this.a ==0)
        {

            this.anime.SetTrigger("jyunpuTigger");
            this.a += 1;
            this.jyuuryoku.AddForce(transform.up * this.jyunp);
        }
        if(this.a == 2)
        {
            
            this.jyunp = 0;
            this.jyuuryoku.AddForce(transform.up * this.jyunp);
       
        }
        if(b>2.0f)
        {
            this.b = 0;
            this.a = 0;
        }
        if (this.jyuuryoku.velocity.y>0.1f)
        {
         
            this.anime.speed = 0.7f;
        }
        else { this.anime.speed = this.idou - 7; }




    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("ゴール");
    }
}

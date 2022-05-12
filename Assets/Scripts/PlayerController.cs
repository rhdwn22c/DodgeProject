using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody; // 이동에 사용할 중력 컴포넌트
    public float speed = 8f; // 이속

    void Start()
    {
        //오브젝트에서 Rigidbody 컴포넌트를 찾아 playerRigidbody에 할당
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // 수평축과 수직축의 입력값을 감지하여 저장 
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // 실제 이속을 입력값과 이속을 사용해 결정
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // Vector3 속도를 (xSpeed, 0f, ZSpeed)로 생성
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        //중력의 속도에 newVelocity 할당
        playerRigidbody.velocity = newVelocity;


    }

    public void Die()
    {
        // 자신의 플레이어 오브젝트를 비활성화
        gameObject.SetActive(false);
    }
}

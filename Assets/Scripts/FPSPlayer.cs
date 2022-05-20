using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSPlayer : MonoBehaviour
{
    public float moveSpeed = 10.0f;


    void Start()
    {
        // ���콺�� ȭ������ ������Ű�� �����.
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime);
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime);
    }
}

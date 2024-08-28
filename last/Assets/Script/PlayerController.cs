using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �v���C���[�̈ړ��𐧌䂷��N���X
public class PlayerController : MonoBehaviour
{
    // �ړ����x
    public float moveSpeed = 5f;

    // ���t���[���Ăяo����郁�\�b�h
    void Update()
    {
        // �������̓��͂��擾
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        // �c�����̓��͂��擾
        float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        // ���͂Ɋ�Â��ăv���C���[���ړ�
        transform.Translate(moveX, 0, moveZ);
    }
}
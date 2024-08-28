using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// プレイヤーの移動を制御するクラス
public class PlayerController : MonoBehaviour
{
    // 移動速度
    public float moveSpeed = 5f;

    // 毎フレーム呼び出されるメソッド
    void Update()
    {
        // 横方向の入力を取得
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        // 縦方向の入力を取得
        float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        // 入力に基づいてプレイヤーを移動
        transform.Translate(moveX, 0, moveZ);
    }
}
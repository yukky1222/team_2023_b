using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAxisTest : MonoBehaviour
{
    Vector3 pos;
void Start()
{
    //オブジェクトの現在の座標を入手
    pos = transform.position;
}
void Update()
{
    //横矢印入力を値で返し変数「yokoyajirushi」に格納
    float yokoyajirushi = Input.GetAxis("Horizontal");
    //縦矢印入力を値で返し変数「tateyajirushi」に格納
    float tateyajirushi = Input.GetAxis("Vertical");
    //変数「pos」のx軸における座標を毎フレーム毎に「yokoyajirushi」の分だけ増加
    pos.x += yokoyajirushi;
    //変数「pos」のy軸における座標を毎フレーム毎に「tateyajirushi」の分だけ増加
    pos.z += tateyajirushi;
    //変数「pos」の値をオブジェクトの座標に反映させる
    transform.position = pos;
}
}
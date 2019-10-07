using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QiButton : MonoBehaviour
{
    public Sprite heiqiSprite;
    public Sprite baiqiSprite;

    public GameObject hongDian;
    public Image QiImage;

    public QiZhiStatus qiZhiStatus;
    public Chessboard chessboard;
    public int x;
    public int y;

    public void Init(int x, int y, Chessboard chessboard)
    {
        this.x = x;
        this.y = y;
        this.chessboard = chessboard;
        hongDian.SetActive(false);
        SetRenjuPiecesStatus(QiZhiStatus.Null);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRenjuPiecesStatus(QiZhiStatus qiZhiStatus)
    {
        this.qiZhiStatus = qiZhiStatus;
        if (qiZhiStatus == QiZhiStatus.Null)
        {
            QiImage.sprite = null;
            QiImage.gameObject.SetActive(false);
        }
        else if (qiZhiStatus == QiZhiStatus.Bai)
        {
            QiImage.sprite = baiqiSprite;
            QiImage.gameObject.SetActive(true);
        }
        else if(qiZhiStatus == QiZhiStatus.Hei)
        {
            QiImage.sprite = heiqiSprite;
            QiImage.gameObject.SetActive(true);
        }

    }
}

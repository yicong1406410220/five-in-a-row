using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chessboard : MonoBehaviour
{
    public GameObject qiButton;

    public QiButton[,] QiButton = new QiButton[15, 15];

    public void Init()
    {
        int startx = -294;
        int starty = -294;
        int space = 42;
        for (int i = 0; i < QiButton.GetLength(0); i++)
        {
            for (int j = 0; j < QiButton.GetLength(0); j++)
            {
                GameObject go = Instantiate<GameObject>(qiButton, transform);
                go.transform.localPosition = new Vector2(startx + space * i, starty + space * j);
                QiButton qiButtonScript = go.GetComponent<QiButton>();
                qiButtonScript.Init(i, j, this);
                QiButton[i, j] = qiButtonScript;
            }
        }

    }

    public void SetRenjuPiecesStatus(int x, int y, QiZhiStatus qiZhiStatus)
    {
        QiButton[x, y].SetRenjuPiecesStatus(qiZhiStatus);
    }

    // Start is called before the first frame update
    void Start()
    {
        Init();
        //SetRenjuPiecesStatus(1, 14, QiZhiStatus.Hei);
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void Hide()
    {
        QiButton = new QiButton[15, 15];
    }
}

public enum QiZhiStatus
{
    Null,
    Hei,
    Bai
}
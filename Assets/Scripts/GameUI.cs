using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class Box
{
    public static int score;

    int number;

    public int num => number;
    public Box(int number)
    {
        this.number = number;
    }

}

public class GameUI : MonoBehaviour
{
    // �̱��� ����.
    // = ������ �ϳ��� �����ϴ� Ŭ������ ����Ѵ�.
    //   ���� �ʱ�ȭ �ܰ迡�� ���� static������ ��������
    //   ��𼭵� ���� �����ϵ��� �ϴ� ���.
    static GameUI instance;
    public static GameUI Instance => instance;


    [SerializeField] Text scoreText;

    // Awake�� Start���� ���� �Ҹ��� �ʱ�ȭ �Լ�.
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        UpdateScoreText(0);
    }

    public void UpdateScoreText(int score)
    {
        scoreText.text = score.ToString();
    }
}

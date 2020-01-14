using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movingBall : MonoBehaviour
{
    //public GameObject PosPosBallTopLeft;
    //public GameObject PosPosBallTopRight;
    //public GameObject PosPosBallBottomLeft;
    //public GameObject PosPosBallBottomRigh
    [SerializeField] private GameObject[] ballPositions;
    [SerializeField] private GameObject ball;

    public void MoveBall()
    {
        Debug.Log(Random.Range(0, 1));
    }
}
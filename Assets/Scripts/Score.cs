﻿using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text score;

    void Update()
    {
        score.text = (player.position.z/10).ToString("0");
    }
}

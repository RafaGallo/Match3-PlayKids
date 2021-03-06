﻿using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePanel : MonoBehaviour {

    public static ScorePanel instance = null;
    private void Awake() {
        instance = this;
    }
    public static void SetNewScore(int newScore, bool pulse = true) {
        instance.textRenderer.text = newScore.ToString() + " / " + GameController.curGoalScore;
        if (pulse) {
            instance.pulseTarget.localScale *= instance.pulseIntensity;
        }
    }

    public Text textRenderer;
    public Transform pulseTarget;
    public float pulseIntensity = 1.2f;

}

﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    [SerializeField]
    GameObject identificationFlowchart;
    [SerializeField]
    GameObject differentiationFlowchart;

    // Use this for initialization
    void Start()
    {
        switch (SceneController.Scene.GetGameType())
        {
            case (GameType.Identification):
                identificationFlowchart.gameObject.SetActive(true);
                break;
            case (GameType.Differentiation):
                differentiationFlowchart.gameObject.SetActive(true);
                break;
            default:
                Debug.LogError("Please select between differentiation and identification.");
                break;
        }
    }
}
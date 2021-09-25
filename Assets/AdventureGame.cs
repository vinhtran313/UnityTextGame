using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] private Text textComponent;
    [SerializeField] private State startingState;

    private State state;

    // Start is called before the first frame update
    private void Start()
    {
        state = startingState;
        textComponent.text = state.getStoryText();
    }

    // Update is called once per frame
    private void Update()
    {
        mangageState();
    }

    private void mangageState()
    {
        var nextStates = state.getToNextRoom();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
            textComponent.text = state.getStoryText();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
            textComponent.text = state.getStoryText();
        }

    }
}

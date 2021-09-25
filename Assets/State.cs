using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(10, 14)] [SerializeField] private string storyText;
    [SerializeField] private State[] nextStates;
    public string getStoryText()
    {
        return storyText;
    }

    public State[] getToNextRoom()
    {
        return nextStates;
    }
}

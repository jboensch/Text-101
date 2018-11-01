using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject {

    //The [TextArea(14,10)] modifies the properties of the input text box in Unity, so when we are in the UI, it is easier to see the text there
    [TextArea(14, 10)] [SerializeField] string storyText;

    public string GetStateStory()
    {
        return storyText;
    }
}

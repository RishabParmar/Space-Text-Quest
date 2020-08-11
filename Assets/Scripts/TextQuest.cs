using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State StartingState;
    State state;
    // Start is called before the first frame update
    void Start()
    {
        state = StartingState;
        textComponent.text = state.GetStoryText();
    }

    // Update is called once per frame
    void Update()
    {        
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = state.goToNextState()[0];
            textComponent.text = state.GetStoryText();
        } else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = state.goToNextState()[1];
            textComponent.text = state.GetStoryText();
        }
    }
}

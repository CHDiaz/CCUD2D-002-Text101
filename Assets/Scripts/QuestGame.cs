using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGame : MonoBehaviour{
    //SerializeField means to serial the variable with denote. This means, acording to the Unity Docs:
    //"Serialization is the automatic process of transforming data structures or object states into a format that Unity can store and reconstruct later."
    //textComponent is used as a variable to access the object from out canvas where text is displayed.
    [SerializeField] Text textComponent;
    //shadowTextComponent is used as a variable to access the object from out canvas where text is displayed. It is in a black color and slighty offset from textComponent to create a text shadow.
    [SerializeField] Text shadowTextComponent;
    //startingState is used as a vairable to access the state called statringState.
    [SerializeField] State startingState;
    //We also create a variable called state to keep track of our current state in the game.
    State state;
    // Start is called before the first frame update
    void Start()
    {
        //We initialize state to our startingState, as it should be the first state out game enters.
        state = startingState;
        //Afterwards, we pull the storyText that is in startingState using the function GetStateStory() to populate the text on screen.
        textComponent.text = state.GetStateStory();
        shadowTextComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        // ManageState() will be called at every frame to check for user input and allow progression of states.
        ManangeState();
    }

    // ManageState() will check for the Key inputs "Z" "X" "C" or "V" and progress to the state listed in array position 0,1,2 or 3 respestively.
    // If the arrary size is smaller than the possible option, then the input will be ignored.
    // Afterwards, the storyText on the canvas will be updated.
    void ManangeState() {
        State[] options = state.GetOptions();

        if (Input.GetKeyDown(KeyCode.Z)) {
            if (!(options.Length <= 0)){ state = options[0];}
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            if (!(options.Length <= 1)) { state = options[1]; }
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            if (!(options.Length <= 2)) { state = options[2]; }
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            if (!(options.Length <= 3)) { state = options[3]; }
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            state = startingState;
        }


        textComponent.text = state.GetStateStory();
        shadowTextComponent.text = state.GetStateStory();
    }
}


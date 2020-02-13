using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This syntax allows the creation of a custom option in the Create menu, called "State"
[CreateAssetMenu(menuName = "State")]
//Rather than using MonoBehavior, we are using ScriptableObject that allows us to create objects that do not need to be attached to game objects.
public class State : ScriptableObject{
    //Here we create a string called storyText which is Serialized, and has a text are of 14 words wide, 10 lines down in the inspector. 
    [TextArea (10,14)][SerializeField] string storyText;
    //
    [SerializeField] State[] options;

    public string GetStateStory() {
        return storyText;
    }

    public State[] GetOptions() {
        return options;
    }
}


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseActivity : MonoBehaviour
{
    // Variables
    public string activityName = ""; // Display name of the activity
    public string activityDescription = ""; // Description of the activity
    public string activityInstructions = ""; // Instructions for the activity
    public float activityDuration = 0f; // Duration of the activity
    public bool activityCompleted = false; // Whether the activity has been completed
    public Types.ActivityType activityType = Types.ActivityType.Other; // Type of activity
    



    // Methods
    public void InitializeActivity(string name, string description, string instructions, Types.ActivityType type, float Duration = 30f, Boolean Completed = false)
    {
        /* Update the current values of the activity with the passed in values
         * 
         */
        activityName = name;
        activityDescription = description;
        activityInstructions = instructions;
        activityType = type;
        activityDuration = Duration;
        activityCompleted = Completed;
        
        // Create a new game object to hold the acitivty
        GameObject activity = new GameObject("Activity")
        {
            name = activityName,
            tag = "Activity"
        };
        activity.AddComponent<BaseActivity>();
        // get the activity component and set its values
        BaseActivity activityComponent = activity.GetComponent<BaseActivity>();
        activityComponent.activityName = activityName;
        activityComponent.activityDescription = activityDescription;
        activityComponent.activityInstructions = activityInstructions;
        activityComponent.activityType = activityType;
        activityComponent.activityDuration = activityDuration;
        activityComponent.activityCompleted = activityCompleted;
    }

    
    public void StartActivity()
    {
    
    }
    
    public void EndActivity()
    {
        // Logic
    }
    
    // Getters and Setters
    public string GetActivityName() { return activityName; }
    public float GetActivityDuration() { return activityDuration; }
    public string GetActivityDescription() { return activityDescription; }
    public string GetActivityInstructions() { return activityInstructions; }
    public bool GetActivityCompleted() { return activityCompleted; }
    public Types.ActivityType GetActivityType() { return activityType; }
    
}

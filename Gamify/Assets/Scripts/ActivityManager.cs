using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivityManager : MonoBehaviour
{
    /* parent class in charge of managing the activities of the game
     *
     * 
     */
    // Start is called before the first frame update
    // Variables
    
    void Start()
    {
        // Initialize a new activity for testing
        BaseActivity activity = gameObject.AddComponent<BaseActivity>();
        activity.InitializeActivity("Reading", "Read a book", "Read the book", Types.ActivityType.Reading);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

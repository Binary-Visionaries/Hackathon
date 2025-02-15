using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private int ListLength = 10;

    public int _Level { get; private set; }
    public int _levelXp {  get; private set; }
    public bool _LevelUp { get; private set = false; }

    public int _Exp {  get; private set; }

    public List<string> _RecentActivity {  get; private set; }
    public string _CurrentActivity {  get; private set; }
    public Dictionary<string,int> _History { get; private set; }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    ///
    //Constructor

    //default for new player
    public PlayerManager() 
    {
        _level = 1;
        _levelXp = 100;
        _Exp = 0; 
        _RecentActivity = new List<string>();
        _History = new Dictionary<string,int>();
        _CurrentActivity = null;
    
    }

    //for returning player
    public PlayerManager(int level, int levelXp, int Exp, List<string> recentactivity, Dictionary<string,int> history, string currentactivity) 
    {
        _level = level;
        _levelXp = levelXp;
        _Exp = Exp;
        _RecentActivity = recentactivity;
        _History = history;
        _CurrentActivity = currentactivity;
    }


    ////////////////////
    ///Functions
    ///

    /// Purpose :   Update the level of the player base on the xp gain of the uesr
    /// Input   :   Int ExpGained => xp gained by the user
    
    public void CheckLevel(int ExpGained) 
    {
        _LevelUp = false;
        while( _Exp+= ExpGained > _levelXp) 
        { 
            _Exp -= _levelXp;
            _level++;
            _LevelUp = true;
            ExpGained = 0;
        }
    }


    /// <summary>
    ///     Change current player activity and update accossited fields
    /// </summary>
    /// <param name="activity">New activity that the user is doing</param>
    public void ChangeCurrentActivity(string activity) 
    { 
        if(activity == null)
            return;
        if(_CurrentActivity != null) 
        {
            if(_History.ContainsKey(_CurrentActivity))
            {
                _History[_CurrentActivity]++;
            }
            else 
            {
                _History.Add(_CurrentActivity, 1);
            }
            UpdateRecentActivity(_CurrentActivity);
        }
        _CurrentActivity = activity;
    }

    /// <summary>
    /// Updates the recent activity of the user based o
    /// </summary>
    /// <param name="activity"></param>
    public void UpdateRecentActivity(string activity) 
    { 
        if( activity == null) return;
        while(_RecentActivity.Count() > ListLength) 
        {
            _RecentActivity.RemoveAt(10);
        }
        _RecentActivity.AddFirst(activity);
    
    }
}

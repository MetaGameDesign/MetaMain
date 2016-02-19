//Stores a list of all variables used by the Messenger system for easy reference

using UnityEngine;
using System.Collections;

public static class GameEvent {
    //  Add new game variables for use in Messenger events: public const string VARIABLE_NAME = "EVENT_NAME";
    //  Ex: public const string GAME_COMPLETE = "GAME_COMPLETE";
    public const string GAME_COMPLETE = "GAME_COMPLETE";
    public const string ENERGY_CHANGED = "ENERGY_CHANGED";
    public const string ORE_CHANGED = "ORE_CHANGED";
    public const string GOLD_CHANGED = "GOLD_CHANGED";
    public const string VP_CHANGED = "VP_CHANGED";
    public const string UNIT_SELECTED = "UNIT_SELECTED";
    public const string CAPITAL_SELECTED = "CAPITAL_SELECTED";
}

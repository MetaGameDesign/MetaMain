//Stores a list of all variables used by the Messenger system for easy reference during start-up
//  By default, includes variables used by the StartupController to first initialize Managers and ensure they are all started properly

using UnityEngine;
using System.Collections;

public static class StartupEvent {
    public const string MANAGERS_STARTED = "MANAGERS_STARTED";
    public const string MANAGERS_PROGRESS = "MANAGERS_PROGRESS";
	
}

using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class SavePlayerName : MonoBehaviour {

    [SerializeField]
    InputField nameInput;


    private const string FILE_NAME = "PlayerNames.txt";

    

    public void GetPlayerName()
    {
        string playerName = nameInput.text;

        /*if (!File.Exists(FILE_NAME))
        {
            File.CreateText(FILE_NAME);
        }*/

        using (StreamWriter sw = new StreamWriter(FILE_NAME, true))
        {
            sw.WriteLine("Date: " + System.DateTime.Now);
            sw.WriteLine("Version: " + SceneController.Main.GetGameType().ToString());
            sw.WriteLine("Player Name: " + playerName);
            sw.WriteLine("-----------------------------");
            
        }
    }
}

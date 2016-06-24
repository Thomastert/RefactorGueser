using UnityEngine;
using System.Collections;

public class ProfileIcon : MonoBehaviour {
    private int icon;
    private string summonerName;
    private SaveData saveDataScript;
    
    public void SaveIcon()
    {
        saveDataScript.StoreData(new EnterData(summonerName, icon, saveDataScript.LP, saveDataScript.IP));
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProfileName : MonoBehaviour {
    [SerializeField] private Text nameText;
    private SaveData saveDataScript;
    private string summonerName;

    private void SetSummonerName()
    {
        saveDataScript.GetData();
        summonerName = saveDataScript.Nickname;
    }

}

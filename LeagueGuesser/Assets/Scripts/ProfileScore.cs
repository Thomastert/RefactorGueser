using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProfileScore : MonoBehaviour {

    private DivisionChecker divisionChecker;
    private int ip = 1337;
    private SaveData saveDataScript;
    [SerializeField]
    private Image LPBar;
    private string summonerName;
    [SerializeField]
    private Text IPText;

    public void SetPoints()
    {
        saveDataScript.GetData();
        ip = saveDataScript.IP;
        IPText.text = "" + ip;

    }
    public int GetPoints()
    {
        return saveDataScript.IP;
    }

    public void SetElo(int lp)
    {
        saveDataScript.GetData();
        saveDataScript.StoreData(new EnterData(summonerName, saveDataScript.IconInt, saveDataScript.LP + lp, saveDataScript.IP));
        saveDataScript.GetData();
        divisionChecker.SetCurrentDivisionWithPoints(saveDataScript.LP);
    }

    public int GetElo()
    {
        return saveDataScript.LP;
    }

    public void SetEloTo(int lp)
    {
        saveDataScript.GetData();
        saveDataScript.StoreData(new EnterData(summonerName, saveDataScript.IconInt, lp, saveDataScript.IP));
    }

    public void AddLeaguePoints(int ip)
    {
        saveDataScript.GetData();
        saveDataScript.StoreData(new EnterData(summonerName, saveDataScript.IconInt, saveDataScript.LP, saveDataScript.IP + ip));
        SetPoints();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Generate : MonoBehaviour
{
    //assign in inspector
    public TMP_InputField toughness;
    public TMP_InputField strength;
    public TMP_InputField dexterity;
    public TMP_InputField iQ;
    public TMP_InputField power;
    public TMP_InputField charm;
    public TMP_InputField name;

    public TMP_Text nameDisplay;
    public TMP_Text hPDisplay;
    public TMP_Text sPDisplay;
    public TMP_Text tDisplay;
    public TMP_Text sDisplay;
    public TMP_Text dDisplay;
    public TMP_Text iDisplay;
    public TMP_Text pDisplay;
    public TMP_Text cDisplay;


    //player data
    private int tou;
    private int str;
    private int dex;
    private int i;
    private int pow;
    private int cha;
    private string nam;

    private int hP;
    private int sP;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GeneratePlayer()
    {
        if (IfFilled())
        {
            GetData();
            ProcessData();
            AssignData();
        }
        
    }

    public void RandomizePlayer()
    {
        RandomizeData();
        ProcessData();
        AssignData();
    }

    private bool IfFilled() //cant gen if theres blank
    {
        if (toughness.text.Equals("") || strength.text.Equals("") || dexterity.text.Equals("") || iQ.text.Equals("") || power.text.Equals("") || charm.text.Equals("") || name.text.Equals(""))
        {
            return false;
        }
        else
        {
            return true;
        }
        
    }
    
    private void GetData()
    {
        tou = int.Parse(toughness.text);
        str = int.Parse(strength.text);
        dex = int.Parse(dexterity.text);
        i = int.Parse(iQ.text);
        pow = int.Parse(power.text);
        cha = int.Parse(charm.text);
        nam = name.text;
    }

    private void RandomizeData()
    {
        tou = Random.Range(1,101);
        str = Random.Range(1,101);
        dex = Random.Range(1,101);
        i = Random.Range(1,101);
        pow = Random.Range(1,101);
        cha = Random.Range(1,101);
        
        string[] orcs ={ "Vigdolg", "Oggha", "Ghamborz","Burul","Koffutto","Bildud","Prikdarok","Snakha","Zonagh", "Pigdug" };
        nam = orcs[Random.Range(0, orcs.Length)];
    }
    
    private void ProcessData()
    {
        hP = (str + pow + tou)/ 3;  //take the middle number
        sP = (dex + i + cha) / 3;
    }

    private void AssignData()
    {
        nameDisplay.text = "Name: " + nam;
        hPDisplay.text = "HP: " + hP;
        sPDisplay.text = "SP: " + sP;
        tDisplay.text = "Toughness: " +tou;
        sDisplay.text = "Strength: "+str;
        dDisplay.text = "Dexterity: "+dex;
        iDisplay.text = "IQ: "+i;
        pDisplay.text = "Power: "+pow;
        cDisplay.text = "Charm: "+cha;
    }
}

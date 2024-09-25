using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static UnityEngine.UI.Image;
using System.Diagnostics;
using System.Xml.Linq;
using UnityEditor.Playables;

public class Player2 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Domain;
    string Name = "Unggoy Baboy";
    string Gender = "N/A";
    int Age = 12;
    string Race = "Cagayan Monkey";
    int Powerlevel = 99999000;
    string Sexuality = "Attracted to ripe bananas";
    string Occupation = "Terminator of Mankind";

    public void UnggoyBaboy()
    {
        Domain.text = ("Name: " + Name + "\r\nRace: " + Race + "\r\nGender: " + Gender + "\r\nSexuality: " + Sexuality + "\nPowerlevel: " + Powerlevel + "\nOccupation: " + Occupation + "\nAge: " + Age);
    }
}



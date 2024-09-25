using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static UnityEngine.UI.Image;
using System.Diagnostics;
using System.Xml.Linq;
using UnityEditor.Playables;

public class Player1 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Domain;
    string Name = "Jose Marimar";
    string Gender = "Male";
    int Age = 96;
    string Race = "Mexican Filipino";
    int Powerlevel = 9000;
    string Sexuality = "Attracted to pans";
    string Occupation = "Gardener Nurse";

    public void JoseMarimar()
    {
        Domain.text = ("Name: " + Name + "\r\nRace: " + Race + "\r\nGender: " + Gender + "\r\nSexuality: " + Sexuality + "\nPowerlevel: " + Powerlevel + "\nOccupation: " + Occupation + "\nAge: " + Age);
    }
}



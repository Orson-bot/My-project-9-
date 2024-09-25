using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static UnityEngine.UI.Image;
using System.Diagnostics;
using System.Xml.Linq;
using UnityEditor.Playables;

public class Player3 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Domain;
    string Name = "Nobita Nomi";
    string Gender = "Male";
    int Age = 16;
    string Race = "Japanese Filipino";
    int Powerlevel = 1;
    string Sexuality = "Doraemon";
    string Occupation = "Savior of Mankind";

    public void NobitaNomi()
    {
        Domain.text = ("Name: " + Name + "\r\nRace: " + Race + "\r\nGender: " + Gender + "\r\nSexuality: " + Sexuality + "\nPowerlevel: " + Powerlevel + "\nOccupation: " + Occupation + "\nAge: " + Age);
    }
}

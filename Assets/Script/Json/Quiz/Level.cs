using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Level
{
    public string Name;
    public string Sprite;
    public string Question;
    public List<string> Answers = new List<string>();
    public string CorrectAnswer;
}

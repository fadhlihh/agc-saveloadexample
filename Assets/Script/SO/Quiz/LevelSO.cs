using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "Quiz/Level", order = 1)]
public class LevelSO : ScriptableObject
{
    public string Name;
    public GameObject SomeObject;
    public Sprite Image;
    public string Question;
    public List<string> Answers = new List<string>();
    public string CorrectAnswer;
}

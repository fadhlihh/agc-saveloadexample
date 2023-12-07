using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPackManager : MonoBehaviour
{
    [SerializeField]
    private List<LevelPackSO> _levelPacks;

    private void Start()
    {
        ShowAllData();
    }

    private void ShowData()
    {
        string name = _levelPacks[1].Levels[0].Name;
        string question = _levelPacks[1].Levels[0].Question;
        string correctAnswer = _levelPacks[1].Levels[0].CorrectAnswer;
        List<string> answers = _levelPacks[1].Levels[0].Answers;
        Debug.Log(name);
        Debug.Log(question);
        foreach (string answer in answers)
        {
            Debug.Log(answer);
        }
        Debug.Log(correctAnswer);
    }

    private void ShowAllData()
    {
        foreach (LevelPackSO levelPack in _levelPacks)
        {
            foreach (LevelSO level in levelPack.Levels)
            {
                Debug.Log(level.Name);
            }
        }
    }
}

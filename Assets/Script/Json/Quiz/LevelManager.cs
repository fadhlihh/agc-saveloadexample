using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private TextAsset _levelJson;

    List<LevelPack> _levelPacks = new List<LevelPack>();

    private void Start()
    {
        LoadData();
        Resources.Load<Sprite>("Image/leaf");
    }

    private void LoadData()
    {
        LevelPackList levelPacksData = JsonUtility.FromJson<LevelPackList>(_levelJson.text);
        _levelPacks = levelPacksData.LevelPacks;
        Debug.Log(_levelPacks[0].Levels[0].Question);
    }
}

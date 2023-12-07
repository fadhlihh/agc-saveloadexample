using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelPack", menuName = "Quiz/Level Pack", order = 2)]
public class LevelPackSO : ScriptableObject
{
    public List<LevelSO> Levels = new List<LevelSO>();
}

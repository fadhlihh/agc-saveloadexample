using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    private TextAsset _playerTextAsset;
    [SerializeField]
    private TextAsset _playersTextAsset;
    private List<Player> _players = new List<Player>();

    private void Start()
    {
        LoadAllData();
    }

    public void LoadSingleData()
    {
        Player player = JsonUtility.FromJson<Player>(_playerTextAsset.text);
        Debug.Log(player.Age);
    }

    public void LoadAllData()
    {
        PlayerList playerList = JsonUtility.FromJson<PlayerList>(_playersTextAsset.text);
        _players = playerList.Players;
        Debug.Log(_players[2].Name);
    }
}

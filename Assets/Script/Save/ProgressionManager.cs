using System.IO;
using TMPro;
using UnityEngine;


public class ProgressionManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _coinText;

    private string _saveLocation = "/Save/";
    private string _fileName = "Save.json";

    private PlayerProgress _playerProgress = new PlayerProgress();

    private void Start()
    {
        // Load data when game start and scene loaded
        LoadData();
        UpdateUI();
    }

    public void UpdateUI()
    {
        _coinText.text = _playerProgress.Coin.ToString();
    }

    public void IncreaseCount()
    {
        _playerProgress.Coin += 1;
        UpdateUI();
    }

    public void DecreaseCount()
    {
        _playerProgress.Coin -= 1;
        UpdateUI();
    }

    public void SaveProgress()
    {
        SaveData();
    }

    public void LoadProgress()
    {
        LoadData();
    }

    private void LoadData()
    {
        // Set load file directory and full path
        string directory = Application.persistentDataPath + _saveLocation;
        string path = directory + _fileName;

        // Check if save file exists
        if (File.Exists(path))
        {
            // If save file exists then load data
            // Read json file and store text in textDataFile variable
            string textDataFile = File.ReadAllText(path);

            // Convert from json string to _levelProgress object
            _playerProgress = JsonUtility.FromJson<PlayerProgress>(textDataFile);
            UpdateUI();
        }

        else
        {
            // If save file not found then create directory and set initial data
            Directory.CreateDirectory(directory);
            SetInitialData();
        }
    }

    private void SetInitialData()
    {
        _playerProgress.Coin = 0;
        SaveData();
    }

    private void SaveData()
    {
        // Set save file directory and full path
        string directory = Application.persistentDataPath + _saveLocation;
        string path = directory + _fileName;

        // Convert _levelProgress object to string data and store it in textData
        string textData = JsonUtility.ToJson(_playerProgress);
        // Write data into File
        File.WriteAllText(path, textData);
    }
}

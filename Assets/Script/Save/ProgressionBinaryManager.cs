using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TMPro;
using UnityEngine;

public class ProgressionBinaryManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _coinText;

    private string _saveLocation = "/Save/";
    private string _fileName = "Save.sav";

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
            // Create BinaryFormatter object to deserialize binary file format to object 
            BinaryFormatter formatter = new BinaryFormatter();
            // Read binary file using file stream
            FileStream dataFile = new FileStream(path, FileMode.Open);
            // Deserialize binary file to LevelProgression object
            PlayerProgress playerProgress = formatter.Deserialize(dataFile) as PlayerProgress;
            if (playerProgress != null)
            {
                _playerProgress = playerProgress;
            }
            // If you are using file stream then don’t forget to close file 
            dataFile.Close();
        }
        else
        {
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

        // Create BinaryFormatter object to deserialize binary file format to object
        BinaryFormatter formatter = new BinaryFormatter();

        // Create binary file using file stream
        FileStream dataFile = new FileStream(path, FileMode.Create);

        // Deserialize binary file to LevelProgression object
        formatter.Serialize(dataFile, _playerProgress);

        // If you are using file stream then don’t forget to close file
        dataFile.Close();
    }

}

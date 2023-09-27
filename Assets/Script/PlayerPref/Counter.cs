using System.Data.Common;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _counterText;
    private int _counter;
    private void Start()
    {
        _counter = 0;
        UpdateCounterUI();
    }

    public void IncreaseCount()
    {
        _counter += 1;
        UpdateCounterUI();
    }

    public void DecreaseCount()
    {
        _counter -= 1;
        UpdateCounterUI();
    }

    public void UpdateCounterUI()
    {
        _counterText.text = _counter.ToString();
    }

    public void LoadData()
    {
        bool isDataAvailable = PlayerPrefs.HasKey("Counter");
        if (isDataAvailable == true)
        {
            _counter = PlayerPrefs.GetInt("Counter");
            UpdateCounterUI();
        }
        else
        {
            Debug.Log("Data not found!");
        }
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt("Counter", _counter);
        Debug.Log("Data Saved");
        PlayerPrefs.Save();
    }
}

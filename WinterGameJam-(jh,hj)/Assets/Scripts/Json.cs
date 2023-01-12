using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class SaveData
{
    public float effect;
    public float background;
}
public class Json : MonoBehaviour
{
    SaveData saveData;
    string savePath;
    string saveFileName = "/SaveFile.txt";
    [SerializeField] Slider effectslider;
    [SerializeField] Slider backgroundslider;
    private void Start()
    {
        saveData = new SaveData();
        savePath = Application.dataPath + "/SaveData/";
        if (!Directory.Exists(savePath)) Directory.CreateDirectory(savePath);
    }
    private void OnEnable()
    {
        if (File.Exists(savePath + saveFileName))
        {
            string loadJson = File.ReadAllText(savePath + saveFileName);
            saveData = JsonUtility.FromJson<SaveData>(loadJson);

            effectslider.value = saveData.effect;
            backgroundslider.value = saveData.background;
        }
        else
        {
            Debug.Log("저장 자료가 없습니다");
        }
    }
    private void Update()
    {
        saveData.effect = effectslider.value;
        saveData.background = backgroundslider.value;

        string json = JsonUtility.ToJson(saveData);

        File.WriteAllText(savePath + saveFileName, json);
        Debug.Log(json);
    }
    private void FixedUpdate()
    {
        if (File.Exists(savePath + saveFileName))
        {
            string loadJson = File.ReadAllText(savePath + saveFileName);
            saveData = JsonUtility.FromJson<SaveData>(loadJson);

            effectslider.value = saveData.effect;
            backgroundslider.value = saveData.background;
        }
    }
}

using System.IO;
using UnityEngine;
using System.Collections.Generic;
using UnityEditor;

[RequireComponent(typeof(GameController))]
public class SaveScript : MonoBehaviour{
    private GameController gameController;
    private string savePath;

    void Start(){
        gameController = GetComponent<GameController>();
        savePath = Application.dataPath + "/Resources/Saves/SaveGame.json";
    }

    public void SaveData(){
        var playerSave = new PlayerSave(){
            savedLevel = gameController.Level,
            savedName = gameController.Name[gameController.nameRange],
            savedClass = gameController.Class[gameController.classRange],
            savedVitality = gameController.Vitality,
            savedAttunement = gameController.Attunement,
            savedEndurance = gameController.Endurance,
            savedStrength = gameController.Strength,
            savedDexterity = gameController.Dexterity,
            savedResistance = gameController.Resistance,
            savedIntelligence = gameController.Intelligence,
            savedFaith = gameController.Faith,
            savedHumanity = gameController.Humanity,
            savedSouls = gameController.Souls
        };

        string json = JsonUtility.ToJson(playerSave,true);
        Debug.Log(json);
        savePath = Application.dataPath + "/Resources/Saves/SaveGame.json";
        Debug.Log(savePath);
        File.WriteAllText(savePath,json);

        AssetDatabase.Refresh();

        Debug.Log("Data Saved");
    }

    public void LoadData(){
        if (File.Exists(savePath)){
            TextAsset jsonString = Resources.Load<TextAsset>("Saves/SaveGame");
            PlayerSave playerSave = JsonUtility.FromJson<PlayerSave>(jsonString.text);

            gameController.Level = playerSave.savedLevel;
            gameController.nameRange = System.Array.IndexOf(gameController.Name, playerSave.savedName);
            gameController.classRange = System.Array.IndexOf(gameController.Class, playerSave.savedClass); 
            gameController.Vitality = playerSave.savedVitality;
            gameController.Attunement = playerSave.savedAttunement;
            gameController.Endurance = playerSave.savedEndurance;
            gameController.Strength = playerSave.savedStrength;
            gameController.Dexterity = playerSave.savedDexterity;
            gameController.Resistance = playerSave.savedResistance;
            gameController.Intelligence = playerSave.savedIntelligence;
            gameController.Faith = playerSave.savedFaith;
            gameController.Humanity = playerSave.savedHumanity;
            gameController.Souls = playerSave.savedSouls;
            gameController.ShowData();

            Debug.Log("Data Loaded");
        } else{
            Debug.LogWarning("Save file doesn't exist!");
        }
    }
}
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour{
    public string[] Name = new string[10] {"Fulbert", "Ewald", "Saebald", "Turold", "Archibald", "Godlefe", "Eadgyd", "Herewynn", "Waerblith", "Eanswyth"};
    public string[] Class = new string[10] {"Warrior", "Knight", "Wanderer", "Thief", "Bandit", "Hunter", "Sorcerer", "Pyromancer", "Cleric", "Deprived"};
    public int Level {get; set;}
    public int Vitality {get; set;}
    public int Attunement {get; set;}
    public int Endurance {get; set;}
    public int Strength {get; set;}
    public int Dexterity {get; set;}
    public int Resistance {get; set;}
    public int Intelligence {get; set;}
    public int Faith {get; set;}
    public int Humanity {get; set;}
    public int Souls {get; set;}
   
    [SerializeField]
    public Text nameText;
    [SerializeField]
    public Text classText;
    [SerializeField]
    public Text levelText;
    [SerializeField]
    public Text vitalityText;
    [SerializeField]
    public Text attunementText;
    [SerializeField]
    public Text enduranceText;
    [SerializeField]
    public Text strengthText;
    [SerializeField]
    public Text dexterityText;
    [SerializeField]
    public Text resistanceText;
    [SerializeField]
    public Text intelligenceText;
    [SerializeField]
    public Text faithText;
    [SerializeField]
    public Text humanityText;
    [SerializeField]
    public Text soulsText;

    public int nameRange;
    public int classRange;

    public void GenerateNewData(){
        Level = Random.Range(1,60);
        nameRange = Random.Range(0,9);
        classRange = Random.Range(0,9);
        Vitality = Random.Range(8,60);
        Attunement = Random.Range(8,60);
        Endurance = Random.Range(8,60);
        Strength = Random.Range(8,60);
        Dexterity = Random.Range(8,60);
        Resistance = Random.Range(8,60);
        Intelligence = Random.Range(8,60);
        Faith = Random.Range(8,60);
        Humanity = Random.Range(8,60);
        Souls = Random.Range(0,600000);
        ShowData();
    }

    public void ShowData(){
        nameText.text = Name[nameRange];
        classText.text = Class[classRange];
        levelText.text = Level.ToString();
        vitalityText.text = Vitality.ToString();
        attunementText.text = Attunement.ToString();
        enduranceText.text = Endurance.ToString();
        strengthText.text = Strength.ToString();
        dexterityText.text = Dexterity.ToString();
        resistanceText.text = Resistance.ToString();
        intelligenceText.text = Intelligence.ToString();
        faithText.text =  Faith.ToString();
        humanityText.text =  Humanity.ToString();
        soulsText.text = Souls.ToString();
    }
}
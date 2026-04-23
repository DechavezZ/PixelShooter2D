using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int monedas;
    public TMP_Text texto; 

    void Start()
    {
        monedas = PlayerPrefs.GetInt("monedas", 0);
    }

    void Update()
    {
        texto.text = "Monedas: " + monedas;
    }

    public void SumarMoneda()
    {
        monedas++;
        PlayerPrefs.SetInt("monedas", monedas);
        PlayerPrefs.Save();
    }
}
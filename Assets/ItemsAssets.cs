using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsAssets : MonoBehaviour
{
    public static ItemsAssets Instance { get; private set; }

    public Sprite spriteSpada;
    public Sprite spritePozioneSalute;
    public Sprite spriteSoldi;
    public Sprite spriteLancia;
    public Sprite spritePozioneVelocita;
    public Sprite spritePozioneSalto;

    public string spadaNome = "spada di ferro";
    public string soldiNome = "soldi";
    public string pozioneSaluteNome = "pozione salute";
    public string lanciaNome = "lancia di ferro";
    public string pozioneVelocitaNome = "pozione velocita";
    public string pozioneSaltoNome = "pozione salto";

    public Transform pfItemWorld;

    private void Awake()
    {
        Instance = this;
    }

   
}

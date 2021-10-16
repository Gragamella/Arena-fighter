using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items 
{
   public enum ItemType
    {
        Spada,
        PozioneSalute,
        PozioneVelocita,
        PozioneSalto,
        Lancia,
        Frusta,
        Monete,
        Gioelli
    }

    public ItemType tipoOggetto;
    public int quantità;
    public string nome;

    public Sprite GetSprite()
    {
        switch (tipoOggetto)
        {
            default:
            case ItemType.Spada: return ItemsAssets.Instance.spriteSpada;
            case ItemType.PozioneSalute: return ItemsAssets.Instance.spritePozioneSalute;
            case ItemType.Monete: return ItemsAssets.Instance.spriteSoldi;
            case ItemType.Lancia: return ItemsAssets.Instance.spriteLancia;
            case ItemType.PozioneVelocita: return ItemsAssets.Instance.spritePozioneVelocita;
            case ItemType.PozioneSalto: return ItemsAssets.Instance.spritePozioneSalto;
        }
    }

    public string GetNomeOggetto()
    {
        switch (tipoOggetto)
        {
            default:
            case ItemType.Spada: return ItemsAssets.Instance.spadaNome;
            case ItemType.PozioneSalute: return ItemsAssets.Instance.pozioneSaluteNome;
            case ItemType.Monete: return ItemsAssets.Instance.soldiNome;
        }
    }

}

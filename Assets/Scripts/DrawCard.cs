using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System.Diagnostics;

public class DrawCard : MonoBehaviour
{
    [SerializeField] private List<CardStat> cards;

    private CardStat DrawnCard;

    private void Update()
    {
        if (Input.GetButtonDown("D"))
        {
            DrawnCard = cards[Random.Range(0, cards.Count)];
            DrawnCard.CardInvoke();
        }
    }
        //switch(DrawnCard)
        //{
        //    case Skrypt1:
        //        DrawnCard = null;
        //        break;

        //}
}

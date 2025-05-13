using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System.Diagnostics;

public class DrawCard : MonoBehaviour
{
    [SerializeField] private List<CardStat> cards;

    private CardStat DrawnCard;

    [SerializeField] private List<CardStat> DeckOfCards;
    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            //DrawnCard = cards[Random.Range(0, cards.Count)];
            int randomIndex = Random.Range(0, cards.Count);
            var DrawnCard = cards[randomIndex];
            DrawnCard.CardInfo();
        }
    }
    //public CardStat cardList;
    //private List<Transform> remainingCards = new List<Transform>();

    //void Start()
    //{
    //    foreach (GameObject prefab in cardList.cards)
    //    {
    //        GameObject instance = GameObject.Find(prefab.name);
    //        if (instance != null)
    //            remainingCards.Add(instance.transform);
    //        else
    //            Debug.LogWarning("Nie znaleziono obiektu w scenie: " + prefab.name);
    //    }
    //}

    //void Update()
    //{
    //    if (!Input.GetKeyDown(KeyCode.Space)) return;

    //    int index = Random.Range(0, remainingCards.Count);
    //    Transform selected = remainingCards[index];
    //    selected.position += Vector3.up * lift;
    //    remainingCards.RemoveAt(index);
    //}
    //switch(DrawnCard)
    //{
    //    case Skrypt1:
    //        DrawnCard = null;
    //        break;

    //}
}

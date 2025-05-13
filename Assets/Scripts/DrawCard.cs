using UnityEngine;
using System.Collections.Generic;

public class DrawCard : MonoBehaviour
{
    [SerializeField] private List<CardStat> cards;
    [SerializeField] private List<CardStat> DeckOfCards;

    private CardStat DrawnCard;
    private CardStat playerCard, enemyCard;

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            DrawMethod(true);
            DrawMethod(false);
            CountPoints();
        }
    }
    private void DrawMethod(bool isPlayer)
    {
        if (cards.Count == 0)
        {
            return;
        }
        //DrawnCard = cards[Random.Range(0, cards.Count)];
        int randomIndex = Random.Range(0, cards.Count);
        var DrawnCard = cards[randomIndex];
        cards.RemoveAt(randomIndex);
        DrawnCard.CardInfo();

        if (isPlayer == true)
        {
            playerCard = DrawnCard;
        } else
        {
            enemyCard = DrawnCard;
        }


    }
    private void CountPoints()
    {
        switch (playerCard.Worth() - enemyCard.Worth())
        {
            case < 0:
                Debug.Log("wygrywa Przeciwnik");
                return;
            case > 0:
                Debug.Log("Wygrywasz");
                return;
            case 0:
                Debug.Log("remis");
                return;
        }
    } 
}

using UnityEngine;

public class CardStat : MonoBehaviour
{
    [SerializeField] private CardDataSO _cardDataSO;
    
    public void CardInfo()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //_cardDataSO.hP *= 2;
            _cardDataSO.SayHello();
        }
    }
    public int Worth()
    {
        return _cardDataSO.CardPoints;
    }
}

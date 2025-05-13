using UnityEngine;

public class CardStat : MonoBehaviour
{
    [SerializeField] private CardDataSO _cardDataSO;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void CardInvoke()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _cardDataSO.hP *= 2;
            _cardDataSO.SayHello();
        }
    }
}

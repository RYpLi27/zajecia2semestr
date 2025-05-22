using UnityEngine;

[CreateAssetMenu(fileName = "CardDataSO", menuName = "Scriptable Objects/CardDataSO")]
public class CardDataSO : ScriptableObject
{
    public string cardName;
    public int hP;
    public int damage;

    public int CardPoints;

    [TextArea] public string designIdea;

    public void SayHello()
    {
        //Debug.Log(cardName);
        //Debug.Log(damage);
        Debug.Log(CardPoints);
    }
}

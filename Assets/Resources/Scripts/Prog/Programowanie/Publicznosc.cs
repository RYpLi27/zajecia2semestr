using UnityEngine;

// public class Publicznosc - to klasa
public class Publicznosc : MonoBehaviour
{
    public void FunkcjaPubliczna()
    {
        // Funkcja bez parametr�w
        // Public - dost�pna w innych klas (czyli np w Funkcje2)
    }

    private void FunkcjaPrywatna()
    {
        // Funkcja prywatna
        // Private - dost�pna tylko w tej klasie (niedost�pne w Funkcje2)
    }
}

public class Funkcje2 : MonoBehaviour
{
    Publicznosc funkcje = new Publicznosc(); // Tworzy nowy obiekt klasy Funkcje

    private void Start()
    {
        funkcje.FunkcjaPubliczna(); // Wywo�anie funkcji publicznej z klasy Funkcje
    }
}
using System;
using UnityEngine;

public class Eventy : MonoBehaviour
{
    // Eventy umo�liwiaj� nam przypisa� jak�� funkcj� do zdarzenia, kt�re wywo�a si� w odpowiednim momencie.

    // Deklaracja delegata, kt�ry b�dzie przechowywa� funkcje, kt�re chcemy wywo�a�.
    // public delegate void OnPlayerJump();

    // Deklaracja zdarzenia, kt�re b�dzie wywo�ywane w momencie skoku gracza.
    // public static event OnPlayerJump PlayerJump;

    // ALE NAJLEPIEJ PISA� TAK PONIEWA� TO JEST TO SAMO CO WY�EJ:
    // To automatycznie tworzy delegata i event w jednym.
    public static Action PlayerJump; // muszi byc zawsze publiczne

    public void Jump()
    {
        // Wykonuje zdarzenie skoku gracza kt�r zosta�o przypisane.
        // '?' oznacza czy zdarzenie nie jest puste. Je�eli jest puste to nie wywo�uje zdarzenia.
        PlayerJump?.Invoke();
    }
}

// Aby to zadzia�a�o w innych skryptach musimy podpi�� funkcj� do zdarzenia.
// Przyk�ad w innym skrypcie:
public class PrzypisanieEventu : MonoBehaviour
{
    // Subskrybujemy zdarzenie w momencie aktywacji skryptu.
    private void OnEnable()
    {
        Eventy.PlayerJump += Jump;
    }

    // Odsubskrybujemy zdarzenie w momencie deaktywacji skryptu.
    private void OnDisable()
    {
        Eventy.PlayerJump -= Jump;
    }

    // Funkcja z logik� skoku gracza.
    private void Jump()
    {
        Debug.Log("Skok gracza.");
    }
}

// Aby wykona� event wystarczy si� odnie�� tylko do Eventy i wykona� z tamt�d funkcj� w tym przypadku 'Jump'.
// Przyk�ad w innym skrypcie:
public class  WykonanieEventu : MonoBehaviour
{
    private Eventy eventy = new();

    private void Start()
    {
        eventy.Jump();
    }
}

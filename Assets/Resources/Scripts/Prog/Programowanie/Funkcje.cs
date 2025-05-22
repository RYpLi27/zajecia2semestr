using UnityEngine;

public class Funkcje : MonoBehaviour
{
    private void Start()
    {
        Oblicz(2, 3); // Wykonuje funkcj� Oblicz gdzie oblicza wynik i go wy�wietla w konsoli

        int suma = ObliczAleZwroc(1, 2); // Wykonuje funkcj� ObliczAleZwroc gdzie oblicza wynik i go zwraca
        Debug.Log($"ObliczAleZwroc | Suma: {suma}"); // Wy�wietla wynik w konsoli osobno
    }

    private void Oblicz(int p_liczba1, int p_liczba2) // W Funkcjach mo�na przekazywa� parametry. BARDZO PRZYDATNE!!!
    {
        int suma = p_liczba1 + p_liczba2; // Oblicza sum� dw�ch liczb i przypisuje do tymczasowej zmiennej suma
        Debug.Log($"Oblicz | Suma: {suma}"); // Wy�wietla wynik w konsoli
    }

    private int ObliczAleZwroc(int p_liczba1, int p_liczba2)
    {
        int suma = p_liczba1 + p_liczba2;
        return suma;
    }

    // Funkcje publiczne zazwyczaj nie powinny przyjmowa� parametr�w poniewa� mog� by� modyfikowane poza gr�!
    // Jedynie publiczne powinny by� funkcje kt�re zwracaj� warto�� lub wywo�uj� inne funkcje.
    // W normalnym programowanie to trzeba wszystko zabezpiecza� ale w Unity jest to niepotrzebne bo ludzie lubi� modyfikowa� gry.
    // Jedynie przy multiplayerze trzeba zabezpiecza� funkcje publiczne.
}

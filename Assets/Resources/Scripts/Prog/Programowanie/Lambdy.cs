using UnityEngine.UI;
using UnityEngine;

public class Lambdy : MonoBehaviour
{
    // Lambdy to kr�tkie funkcje anonimowe:

    private int[] liczby = new[] { 1, 2, 3, 4, 5 };
    private int sumaLiczb => liczby[1] + liczby[2]; // W�a�ciwo�� obliczaj�ca sum� wybranych element�w tablicy (5 = liczby[1] + liczby[2])
    private int suma => 1 + 2; // W�a�ciwo�� obliczaj�ca prost� sum� (3 = 1 + 2)

    // Przydaj� si� do szybkich wykonywania funkcji anonimowych:
    [SerializeField] private Button button;

    private void Start()
    {
        button.onClick.AddListener(() => Debug.Log("Klikni�to przycisk!")); // Tak samo jak w JavaScripcie.
    }
}

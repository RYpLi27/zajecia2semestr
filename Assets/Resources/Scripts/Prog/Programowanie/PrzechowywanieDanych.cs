using UnityEngine;

[CreateAssetMenu(fileName = "PrzechowywanieDanychj", menuName = "Scriptable Objects/PrzechowywanieDanychj")]
// To po prostu tworzy nowy obiekt w Unity (zak�adka Create->Scriptable Objects->PrzechowywanieDanychj)
// fileName - nazwa pliku (PrzechowywanieDanychj.asset)
// menuName - nazwa w menu (zak�adka Create->Scriptable Objects->PrzechowywanieDanychj) mo�esz co kolwiek tam wpisa�
public class PrzechowywanieDanych : ScriptableObject // dziedziczy po ScriptableObject
{
    // ScriptableObject mo�e przechowywa� jedynie dane. Nie mo�e wykonywa� �adnych funkcji.
    // Mo�na go u�ywa� do przechowywania danych kt�re maj� by� dost�pne w wielu miejscach w grze.
    // Np do przechowywania ustawie� gry, zapusu gry, parametr�w przeciwnik�w itp.

    // Mo�esz podstawowo stworzy� zmienne:
    public int liczba1;
    public int liczba2;

    // Lub te� mo�esz stworzy� struktur� danych:
    // Strukt�ra danych zawsze musi by� [System.Serializable]

    public Dane dane;

    [System.Serializable]
    public struct Dane // Struktura danych
    {
        public int liczba1;
        public int liczba2;
    }

    // Mo�esz te� stworzy� tablic� danych i dynamicznie dodawa� elmenty kt�re potem odczytujesz:

    public Dane[] daneTablica; // Tablica danych
}

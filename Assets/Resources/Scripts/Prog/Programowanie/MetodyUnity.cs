using System.Collections;
using UnityEngine;

public class MetodyUnity : MonoBehaviour
{
    private void Awake()
    {
        // Aktywuje si� przed startem
        // Najlepsze do wczytywania zasob�w
    }
    private void Start()
    {
        // Aktywuje si� na pocz�tku
        // Najlepsze do inicjalizacji
    }

    private void OnEnable()
    {
        // Aktywuje si� gdy skrypt jest aktywny
        // Je�eli obiekt zostanie aktywowany to skrypt z OnEnable na tym obiekcie si� aktywuje
    }

    private void OnDisable()
    {
        // Aktywuje si� gdy skrypt jest nieaktywny 
        // Je�eli obiekt zostanie wy��czony to skrypt z OnDisable na tym obiekcie si� aktywuje
    }

    private void OnDestroy()
    {
        // Aktywuje si� gdy skrypt jest niszczony
        // Je�eli obiekt zostanie zniszczony to skrypt z OnDestroy na tym obiekcie si� aktywuje
    }

    private void Update()
    {
        // Aktywuje si� co klatk�
    }

    private void FixedUpdate()
    {
        // Aktywuje si� co klatk� fizyczn�
    }

    private IEnumerator Coroutine()
    {
        // Aktywuje si� gdy Coroutine jest aktywny
        // Coroutine to funkcja kt�ra dzia�a w tle
        yield return null;
    }

    // Wykrywa kolizj� z innym obiektem gdy obiekt wszed� w kolizj�
    private void OnTriggerEnter(Collider other)
    {
        //if (other.CompareTag("Player"))
        //{
        //    gameObject.SetActive(false);
        //}
    }

    // Wykrywa kilizj� z innym obiektem gdy obiekt jest w kolizji
    private void OnTriggerStay(Collider other)
    {
        
    }

    // Wykrywa kolizj� z innym obiektem gdy obiekt wyszed� z kolizji
    private void OnTriggerExit(Collider other)
    {
        
    }

    // Wykrywa kolizj� z innym obiektem gdy obiekt dotkie kolizji
    private void OnCollisionEnter(Collision collision)
    {
        //if (other.CompareTag("Player"))
        //{
        //    Funkcja BOOM!
        //    gameObject.SetActive(false);
        //}
    }
}

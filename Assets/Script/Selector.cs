using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selector : MonoBehaviour
{
    public GameObject rolo;
    public GameObject paisa;
    public GameObject cale�o;
    public GameObject enemigo;

    public GameObject[] prefabs;

    void Start()
    {
        rolo.SetActive(false);
        paisa.SetActive(false);
        cale�o.SetActive(false);
        enemigo.SetActive(false);

        this.Select(0);
    }

    public void Rolo()
    {
        rolo.SetActive(true);
        Invoke("Enemigo", 1);
    }

    public void Paisa()
    {
        paisa.SetActive(true);
        Invoke("Enemigo", 1);
    }

    public void Cale�o()
    {
        cale�o.SetActive(true);
        Invoke("Enemigo", 1);
    }

    private void Enemigo()
    {
        enemigo.SetActive(true);
        Invoke("Escena", 1);
    }

    private void Escena()
    {
        SceneManager.LoadScene(2);
    }

    public void Select(int index)
    {
        Comunicador.playerPrefab = this.prefabs[index];
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Imterface : MonoBehaviour
{
    private Button btnCena1, btnCena2, btnSair;

    // Start is called before the first frame update
    void Start()
    {
        UIDocument doc = GetComponent<UIDocument>();
        VisualElement root = doc.rootVisualElement;
        btnCena1 = root.Q<Button>("btnCena1");
        btnCena2 = root.Q<Button>("btnCena2");
        btnSair = root.Q<Button>("btnSair");

        btnCena1.clicked += BtnCena1_clicked;
        btnCena2.clicked += BtnCena2_clicked;
        btnSair.clicked += BtnSair_clicked;
    }

    private void BtnSair_clicked()
    {
        Application.Quit();
    }

    private void BtnCena2_clicked()
    {
        SceneManager.LoadScene("Cena2",LoadSceneMode.Additive);
    }

    private void BtnCena1_clicked()
    {
        SceneManager.LoadScene("Cena1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

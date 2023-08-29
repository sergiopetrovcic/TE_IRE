using UnityEngine;

public class player : MonoBehaviour
{
    // Declaração e inicialização de variável privada visível no editor
    [SerializeField]
    private GameObject[] _cams = new GameObject[4];

    // Declaração e inicialização de variável privada
    private float _translateSpeed = 5f;
    private float _rotateSpeed = 50f;

    // Update is called once per frame
    void Update()
    {
        //// Detecta se a tecla W está pressionada (frente)
        //if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        //    //transform.Translate(new Vector3(0, 0, _translateSpeed * Time.deltaTime));
        //    //transform.Translate(new Vector3(0, 0, 1) * _translateSpeed * Time.deltaTime);
        //    transform.Translate(Vector3.forward * _translateSpeed * Time.deltaTime);
        //// Detecta se a tecla S está pressionada (trás)
        //if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        //    //transform.Translate(new Vector3(0, 0, - _translateSpeed * Time.deltaTime));
        //    //transform.Translate(new Vector3(0, 0, -1) * _translateSpeed * Time.deltaTime);
        //    transform.Translate(Vector3.back * _translateSpeed * Time.deltaTime);
        //// Detecta se a tecla A está pressionada (esquerda)
        //if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        //    //transform.Translate(new Vector3(- _translateSpeed * Time.deltaTime, 0, 0));
        //    //transform.Translate(new Vector3(-1, 0, 0) * _translateSpeed * Time.deltaTime);
        //    transform.Translate(Vector3.left * _translateSpeed * Time.deltaTime);
        //// Detecta se a tecla D está pressionada (direita)
        //if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        //    //transform.Translate(new Vector3(_translateSpeed * Time.deltaTime, 0, 0));
        //    //transform.Translate(new Vector3(1, 0, 0) * _translateSpeed * Time.deltaTime);
        //    transform.Translate(Vector3.right * _translateSpeed * Time.deltaTime);

        // Verifica se as teclas W e S ou seta pra cima e seta pra baixo foram pressionadas
        transform.Translate(new Vector3(0, 0, Input.GetAxis("Vertical")) * _translateSpeed * Time.deltaTime);
        // Verifica se as teclas A e D ou seta pra esquerda e seta pra direita foram pressionadas
        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal"), 0) * _rotateSpeed * Time.deltaTime);
        // Verifica se o mouse moveu para cima e para baixo
        transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), 0, 0) * _rotateSpeed * Time.deltaTime);

        // Detecta se a tecla 1 foi pressionada
        if (Input.GetKeyDown(KeyCode.Alpha1))
            SelectCam(0);
        // Detecta se a tecla 2 foi pressionada
        if (Input.GetKeyDown(KeyCode.Alpha2))
            SelectCam(1);
        // Detecta se a tecla 3 foi pressionada
        if (Input.GetKeyDown(KeyCode.Alpha3))
            SelectCam(2);
        // Detecta se a tecla 4 foi pressionada
        if (Input.GetKeyDown(KeyCode.Alpha4))
            SelectCam(3);
    }

    private void SelectCam(int pos)
    {
        // Para cada GameObject cam no vetor _cams
        foreach (GameObject cam in _cams)
            // Desativa
            cam.SetActive(false);
        // Ativa a câmera desejada
        _cams[pos].SetActive(true);
    }
}

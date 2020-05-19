using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSafePlatf : MonoBehaviour
{
    public GameObject _safePlatform;
    public float _range;
    // Start is called before the first frame update

    //Ao iniciar o jogo ira criar em posicoes Random Safe Plataforms para o jogar poder ficar.
    void Start()
    {
        Vector3 _pos = transform.position;
        _pos.x = _pos.x + Random.Range(-_range, _range);
        _pos.z = _pos.z + Random.Range(-_range, _range);

        GameObject.Instantiate(_safePlatform, _pos, Quaternion.identity);
    }
}

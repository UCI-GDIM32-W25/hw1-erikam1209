using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        // Starts the game with the player having 5 seeds to plant
        _numSeedsLeft = _numSeeds;

        // Starts the game with the player not planting any seeds yet
        _numSeedsPlanted = 0;

        // Sets up the Text UI
        //_plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            _playerTransform.Translate(Vector3.right * _speed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            _playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            _playerTransform.Translate(Vector3.left * _speed * Time.deltaTime);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        if(_numSeedsLeft > 0)
        {
            GameObject plant_object = Instantiate(_plantPrefab);
            Vector3 plant_position = _playerTransform.position;
            plant_object.transform.position = plant_position;
            _numSeedsLeft -= 1;
            _numSeedsPlanted += 1;
            //_plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
        }
    }
}

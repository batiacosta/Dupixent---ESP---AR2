using UnityEngine;
 
 public class SineWave : MonoBehaviour {
	 // CANTIDAD DE PARTICULAS POR ROW
     private int numberOfDots = 100;
     private GameObject[] waveDots;
     public GameObject waveDotPrefab;
	 
	 private float disOffset = 2;
 
     private object sineWave;
 	 private float amplitude = 1.0f;
 	 private float factor = 0.5f;
 
     void Start()
     {
         waveDots = new GameObject[numberOfDots];
 
         // INSTANCIAR TODOS LOS CLONES
         for (int i = 0; i < numberOfDots; i++)
         {
             waveDots[i] = Instantiate(waveDotPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z+i*disOffset+Random.Range(-0.5f, 0.5f)), Quaternion.identity) as GameObject;
			 waveDots[i].transform.parent = transform;
         }
     }
 
     void Update()
     {
         // MOVER Y ROTAR LOS PREFABS CON UNA ONDA SUNUSOIDAL
         for (int i = 0; i < numberOfDots; i++)
         {
			Vector3 position = waveDots[i].transform.position ;

            Quaternion rotation = waveDots[i].transform.rotation;
			Vector3 currentEulerAngles = new Vector3(Mathf.Sin(Time.time + i *factor) * amplitude * 2, 0, 0);

			rotation.eulerAngles = currentEulerAngles;

   			position.y = Mathf.Sin(Time.time + i *factor) * amplitude ;
   			waveDots[i].transform.position = position ;
			waveDots[i].transform.rotation = rotation ;
         }

 
     }
 
 }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeArthur : MonoBehaviour {
         
        public RawImage image;
        public Texture2D Image_3;
        public Texture2D Image_2;
        public Texture2D Image_1;
        public Texture2D Image_0;



    public static int vida;

        // Use this for initialization
        void Start()
        {

            image = GetComponent<RawImage>();
            vida = 4;

        }

        // Update is called once per frame
        void Update()
        {
           
            if (vida == 3)
            {
                image.texture = Image_3;
            }
            if (vida == 2)
            {
                image.texture = Image_2;
            }
            if (vida == 1)
            {
                image.texture = Image_1;
            }
            if (vida == 0)
            {
                image.texture = Image_0;
                SceneManager.LoadScene("GameOver");
            }
        }

    
}

class estrelas
{
    //ATRIBUTOS
    private float massa, diametro, temp_media;
    private planeta [] planetas = new planeta[8];
    private planetaAnao [] planetasAnoes = new planetaAnao[5];
    }

    //CONSTRUTORES
    public estrelas(float m, float d, float tm){
        massa = m;
        diametro = d;
        temp_media = tm;
        for (int i = 0; i < 8; i++)
        {
            planetas[i] = new planeta();
        }
        for (int i = 0; i < 5; i++)
        {
            planetasAnoes[i] = new planetaAnao();
        }
    }

    //MÉTODOS

}
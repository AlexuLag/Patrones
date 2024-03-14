using FlyWeight;

FabricaObjetosGraficos fabrica = new FabricaObjetosGraficos();

// Dibujar círculos en diferentes posiciones y colores
DibujarCirculo(fabrica, "rojo", 10, 10);
DibujarCirculo(fabrica, "azul", 20, 20);
DibujarCirculo(fabrica, "rojo", 30, 30);
DibujarCirculo(fabrica, "verde", 40, 40);
DibujarCirculo(fabrica, "azul", 50, 50);


    static void DibujarCirculo(FabricaObjetosGraficos fabrica, string color, int x, int y)
{
    IObjetoGrafico circulo = fabrica.ObtenerObjetoGrafico(color);
    circulo.Dibujar(x, y);
}
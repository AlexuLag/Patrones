using Visitor;

IForma[] formas = {
            new Circulo(3),
            new Cuadrado(5),
            new Triangulo(4)
        };

IVisitante visitante = new VisitanteAreaPerimetro();

foreach (var forma in formas)
{
    forma.Aceptar(visitante);
}
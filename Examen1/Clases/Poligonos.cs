using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1.Clases
{
    public class FiguraGeometrica
    {
        public FiguraGeometrica(string nombre) { 
            this.nombre = nombre;
        }
        public string nombre;
    }

    public interface Poligono
    {
        double area();
    }
    public class Triangulo : FiguraGeometrica, Poligono
    {
        public Triangulo(string nombre,double baseFigura,double altura ) : base(nombre)
        {
            this.altura = altura;
            this.baseFigura = baseFigura;
            superficie = altura * baseFigura / 2;
        }
        public double baseFigura;
        public double altura;
        public double superficie;
        public double area() {
            return superficie;
        }
        public override string ToString()
        {
            return $"{nombre} {superficie}";
        }
    }
    public class Rectangulo : FiguraGeometrica, Poligono
    {
        public Rectangulo(string nombre, double baseFigura, double altura) : base(nombre)
        {
            this.altura = altura;
            this.baseFigura = baseFigura;
            superficie = altura * baseFigura ;
        }
        public double baseFigura;
        public double altura;
        public double superficie;
        public double area()
        {
            return superficie;
        }
        public override string ToString()
        {
            return $"{nombre} {superficie}";
        }
    }
    public class Paralelogramo : FiguraGeometrica, Poligono
    {
        public Paralelogramo(string nombre, double baseFigura, double altura) : base(nombre)
        {
            this.altura = altura;
            this.baseFigura = baseFigura;
            superficie = altura * baseFigura / 2;
        }
        public double baseFigura;
        public double altura;
        public double superficie;
        public double area()
        {
            return superficie;
        }
        public override string ToString()
        {
            return $"{nombre} {superficie}";
        }
    }
}

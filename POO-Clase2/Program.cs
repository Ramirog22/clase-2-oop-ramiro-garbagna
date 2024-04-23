using POO_Clase2.Ejercicio_1;
using POO_Clase2.Ejercicio_2;
using POO_Clase2.Ejercicio_3;

namespace POO_Clase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1
            // Configurar el metodo Emitir sonido para que cada tipo de animal haga un sonido diferente
            // el metodo emitir sonido no devuelve nada (void), imprimir en consola el "sonido"


            Perro perro = new Perro() { Edad = 2, Nombre = "Buddy"};

            Gato gato = new Gato() { Edad = 5, Nombre = "Michi" };

            perro.EmitirSonido();

            gato.EmitirSonido();
            #endregion

            #region Ejercicio 2 
            // Agregar la propiedad "Peso" unicamente para las notebooks 
            // Agregar la propiedad "Refactorizada" que debe ser un booleano unicamente para las PcEscritorio
            // Instanciar una notebook y una pcEscritorio
            // Imprimir por pantalla las propiedades de cada uno
            Notebook nb = new Notebook() { Peso = 15.5f, Marca = "Lenovo" };
            PcEscritorio pc = new PcEscritorio() { Marca = "Dell", Refactorizada = true };

            string pcCondition;
            if (pc.Refactorizada) { pcCondition = "esta refactorizada"; } else { pcCondition = "no esta refactorizada"; }
            Console.WriteLine("La PC de escritorio es marca " + pc.Marca + " y " + pcCondition);
            Console.WriteLine("La notebook es marca " + nb.Marca + " y su peso es de " + nb.Peso);
            #endregion


            #region Ejercicio 3

            // Crear la clase "FiguraGeometrica" la cual debe ser abstracta y tener 2 metodos, uno para calcular el area y el otro el perimetro
            // Crear dos clases "Circulo" y "Rectangulo" que deben heredar de "FiguraGeometrica"
            // Implementar los metodos para que cada figura calcule el area y el perimetro como corresponda
            // Instanciar las clases e imprimir los valores del area y el perimetro para cada figura
            // Mostrar los resultados por consola

            Rectangulo rect = new Rectangulo() { Altura = 5, Base = 3 };
            Circulo cir = new Circulo() { Radio = 5 };

            Console.WriteLine("El area del ciruclo es " + cir.CalcularArea() + " y su perimetro es de " + cir.CalcularPermietro());
            Console.WriteLine("El area del rectangulo es " + rect.CalcularArea() + " y su perimetro es de " + rect.CalcularPermietro());
            #endregion
        }
    }
}
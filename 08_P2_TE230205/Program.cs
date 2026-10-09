Console.WriteLine("CONTROL DE LLENADO DE TANQUE");
Console.WriteLine();

// Crear un objeto de la clase TanqueLiquido
TanqueLiquido tanque1 = new TanqueLiquido();

// Capturar la información del objeto
Console.Write("Ingrese la capacidad máxima del tanque (L): ");
tanque1.CapacidadMaxima = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el volumen inicial del tanque (L): ");
tanque1.VolumenActual = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el volumen agregado por ciclo (L): ");
tanque1.VolumenAgregadoPorCiclo = Convert.ToDouble(Console.ReadLine());

// Mostrar resultados llamando al método del objeto
tanque1.SimularLlenado();

// Definición de la clase TanqueLiquido
class TanqueLiquido
{
    // Propiedades
    public double CapacidadMaxima { get; set; }
    public double VolumenActual { get; set; }
    public double VolumenAgregadoPorCiclo { get; set; }

    // Simular el llenado mediante un ciclo while
    public void SimularLlenado()
    {
        if (VolumenAgregadoPorCiclo <= 0 && VolumenActual < CapacidadMaxima)
        {
            Console.WriteLine("\nError: El volumen agregado por ciclo debe ser mayor a cero.");
            return;
        }

        int ciclo = 1;
        Console.WriteLine();
        Console.WriteLine("--- PROCESO DE LLENADO ---");

        while (VolumenActual < CapacidadMaxima)
        {
            VolumenActual += VolumenAgregadoPorCiclo;

            if (VolumenActual > CapacidadMaxima)
            {
                VolumenActual = CapacidadMaxima;
            }

            double porcentaje = (VolumenActual / CapacidadMaxima) * 100;
            Console.WriteLine($"Ciclo {ciclo}: Volumen actual = {VolumenActual:F2} L | Llenado = {porcentaje:F2} %");
            ciclo++;
        }

        Console.WriteLine("¡El tanque está completamente lleno!");
    }
}
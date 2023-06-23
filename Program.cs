// Modelo (Modelo)
public class Manzana
{
    public string Color { get; set; }
    public int Tamaño { get; set; }
    public string Sabor { get; set; }
}

// Vista Modelo (ViewModel)
public class ManzanaViewModel
{
    private Manzana manzana;

    public string Color
    {
        get { return manzana.Color; }
        set { manzana.Color = value; }
    }

    public int Tamaño
    {
        get { return manzana.Tamaño; }
        set { manzana.Tamaño = value; }
    }

    public string Sabor
    {
        get { return manzana.Sabor; }
        set { manzana.Sabor = value; }
    }

    public ManzanaViewModel(Manzana manzana)
    {
        this.manzana = manzana;
    }
}

// Ejemplo de uso
public class Program
{
    public static void Main()
    {
        // Crear una instancia del modelo (Modelo)
        Manzana manzana = new Manzana();

        // Crear una instancia del vista modelo (ViewModel) y asociarlo con el modelo
        ManzanaViewModel viewModel = new ManzanaViewModel(manzana);

        // Actualizar los datos en el vista modelo
        viewModel.Color = "Rojo";
        viewModel.Tamaño = 5;
        viewModel.Sabor = "Dulce";

        // Mostrar la información de la manzana en la consola
        Console.WriteLine("Información de la manzana");
        Console.WriteLine($"Color: {viewModel.Color}");
        Console.WriteLine($"Tamaño: {viewModel.Tamaño}");
        Console.WriteLine($"Sabor: {viewModel.Sabor}");
    }
}

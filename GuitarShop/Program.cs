public class Program {

    public static void Main(string[] args) {
        Inventory inventory = new Inventory(initializeInventory());

        Guitar guitar = new Guitar("000004", 8254.52, new GuitarSpec("Ning", "Stratocaster", "Alder"));
        Guitar searchResultGuitar = inventory.Search(guitar);

        if (searchResultGuitar != null) {
            PrintGuitarInformation(guitar);
        } else {
            Console.WriteLine("Sorry not Found!!!");
        }

    }

    private static void PrintGuitarInformation(Guitar guitar) {
        Console.WriteLine("*******************************");

        Console.WriteLine("Guitar serial-number: {0}", guitar.GetSerialNumber());
        Console.WriteLine("Guitar Price: {0}", guitar.GetPrice());

        Console.WriteLine("Guitar Builder: Name {0}, Gender {1}, Age {2}.", 
        guitar.GetGuitarSpec().GetBuilder().GetBuilderName(),
        guitar.GetGuitarSpec().GetBuilder().GetBuilderGender(),
        guitar.GetGuitarSpec().GetBuilder().GetBuilderAge());

        Console.WriteLine("Guitar Model: {0}, Year {1}.", 
        guitar.GetGuitarSpec().GetModel().GetModelName(),
        guitar.GetGuitarSpec().GetModel().GetModelYear());

        Console.WriteLine("Guitar Wood Name: {0}, Manufacturer {1}.", 
        guitar.GetGuitarSpec().GetWood().GetWoodName(),
        guitar.GetGuitarSpec().GetWood().GetWoodManufacturer());
        
        Console.WriteLine("*******************************");
    }

    private static Guitar[] initializeInventory() {
        Guitar[] guitars = { new Guitar("000001", 5000.52, new GuitarSpec("Nhong", "Stratocaster", "Alder")),
        new Guitar("000002", 7412.52, new GuitarSpec("Jame", "Stratocaster", "Alder")),
        new Guitar("000003", 3917.52, new GuitarSpec("Jo", "Stratocaster", "Alder")),
        new Guitar("000004", 8254.52, new GuitarSpec("Jo", "Stratocaster", "Alder")),
        new Guitar("000005", 1234.52, new GuitarSpec("Nut", "Stratocaster", "Alder"))};

        return guitars;
    }
}
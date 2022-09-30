public class Wood{
    private string WoodName;
    private string WoodManufacturer;

    public Wood(string WoodName, string WoodManufacturer) {
        this.WoodName = WoodName;
        this.WoodType = WoodManufacturer;
    }

    public string GetWoodName() {
        return this.WoodName;
    }
    public string GetWoodManufacturer() {
        return this.WoodType;
    }

}
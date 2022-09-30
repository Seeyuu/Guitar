public class Model {
    private string ModelName;
    private string ModelYear;

    public Model(string ModelName, string ModelYear) {
        this.ModelName = ModelName;
        this.ModelYear = ModelYear;
    }

    public string GetModelName() {
        return this.ModelName;
    }
    public string GetModelYear() {
        return this.ModelYear;
    }
}
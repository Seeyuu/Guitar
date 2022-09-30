public class Builder {
    private string BuilderName;
    private string BuilderGender;
    private int BuilderAge;

    public Builder(string BuilderName, string BuilderGender, int BuilderAge) {
        this.BuilderName = BuilderName;
        this.BuilderGender = BuilderGender;
        this.BuilderAge = BuilderAge;
    }

    public string GetBuilderName() {
        return this.BuilderName;
    }
    public string GetBuilderGender() {
        return this.BuilderGender;
    }
    public int GetBuilderAge() {
        return this.BuilderAge;
    }
}
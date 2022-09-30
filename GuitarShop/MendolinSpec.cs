public class MendolinSpec {
    private Builder builder;
    private Model model;
    private Wood wood;

    public MendolinSpec(Builder builder,
     Model model,
     Wood wood) {
        this.builder = builder;
        this.model = model; 
        this.wood = wood;
     }

    public Builder GetBuilder() {
        return this.builder;
    }

    public Model GetModel() {
        return this.model;
    }

    public Wood GetWood() {
        return this.wood;
    }

}
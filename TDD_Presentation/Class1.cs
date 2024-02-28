namespace TDD_Presentation
{
    public enum Categories { Lebensmittel, Elektronik, Getränk }

    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Categorie { get; set; }
    }
}

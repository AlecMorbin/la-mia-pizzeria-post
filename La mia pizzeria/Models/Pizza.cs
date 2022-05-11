namespace La_mia_pizzeria.Models
{
    public class Pizza
    {
        public string Name { get; set; }
        public string Descrizione { get; set; }
        public string Image { get; set; }

        public Pizza() { }

        public Pizza(string name, string descrizione, string image)
        {
            this.Name = name;
            this.Descrizione = descrizione;
            this.Image = image;
        }

    }
}

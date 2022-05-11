namespace La_mia_pizzeria.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descrizione { get; set; }
        public string Image { get; set; }

        public Pizza() { }

        public Pizza(int id, string name, string descrizione, string image)
        {
            this.Id = id;
            this.Name = name;
            this.Descrizione = descrizione;
            this.Image = image;
        }

    }
}

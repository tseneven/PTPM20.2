    namespace PTPM20
{
    public class Travel_Package
    {

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int duration;
        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private string availability_of_excursions;
        public string AvailabilityOfExcursions
        {
            get { return availability_of_excursions; }
            set { availability_of_excursions = value; }
        }

        public Travel_Package(string name, int duration, int price, string availability_of_excursions)
        {
            this.name = name;
            this.duration = duration;
            this.price = price;
            this.availability_of_excursions = availability_of_excursions;
        }

        public virtual string Info()
        {
            return $"Название путевки: {name}. Продолжительность в днях: {duration}. Цена: {price}. Наличие экскурсии {availability_of_excursions}";
        }
    }

}

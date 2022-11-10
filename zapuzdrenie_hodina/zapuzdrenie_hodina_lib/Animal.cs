using System.Text;

namespace zapuzdrenie_hodina_lib
{
    public class Animal
    {
        public string Owner { get; set; }
        public double Weight { get; set; }

        protected string name;

        public Animal(string name, double weight, string owner)
        {
            this.name = name;
            this.Weight = weight;
            this.Owner = owner;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine("+++++++++++++++++++++++");
            sb.AppendLine($"Animal {name}");
            sb.AppendLine($"Owner {Owner}");
            sb.AppendLine($"Weights {Weight}kg");
            sb.AppendLine("+++++++++++++++++++++++");
            return sb.ToString();
        }


    }
}
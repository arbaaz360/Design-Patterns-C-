using System;

namespace Builder
{
    public interface IToyBuilder
    {
        void SetModel();
        void SetHead();
        void SetLimbs();
        void SetBody();
        void SetLegs();
        void SetWheels();
        Toy GetToy();
    }

    public class Toy
    {
        public string Model{ get; set; }
        public string Head { get; set; }
        public string Limbs { get; set; }
        public string Body { get; set; }
        public string Legs { get; set; }
        public string Wheels { get; set; }
    }

    public class PremiumToyBuilder : IToyBuilder
    {
        Toy toy = new Toy();
        public void SetModel()
        {
            toy.Model = "TOY A";
        }
        public void SetHead()
        {
            toy.Head = "1";
        }
        public void SetLimbs()
        {
            toy.Limbs = "4";
        }
        public void SetBody()
        {
            toy.Body = "Plastic";
        }
        public void SetLegs()
        {
            toy.Legs = "2";
        }
        public Toy GetToy()
        {
            return toy;
        }

        public void SetWheels()
        {
            toy.Wheels = "4 Wheels";
        }
    }

    public class RegularToyBuilder : IToyBuilder
    {
        Toy toy = new Toy();
        public void SetModel()
        {
            toy.Model = "TOY B";
        }
        public void SetHead()
        {
            toy.Head = "1";
        }
        public void SetLimbs()
        {
            toy.Limbs = "4";
        }
        public void SetBody()
        {
            toy.Body = "Steel";
        }
        public void SetLegs()
        {
            toy.Legs = "4";
        }
        public Toy GetToy()
        {
            return toy;
        }
        public void SetWheels()
        {
            toy.Wheels = "2 Wheels";
        }
    }

    public class ToyDirector
    {
        private IToyBuilder _toyBuilder;
        public ToyDirector(IToyBuilder toyBuilder)
        {
            _toyBuilder = toyBuilder;
        }
        public void CreateFullFledgedToy()
        {
            _toyBuilder.SetModel();
            _toyBuilder.SetHead();
            _toyBuilder.SetLimbs();
            _toyBuilder.SetBody();
            _toyBuilder.SetLegs();
            _toyBuilder.SetWheels();
        }
        public void CreateMVPToy()
        {
            _toyBuilder.SetModel();
            _toyBuilder.SetHead();
            _toyBuilder.SetLimbs();
            _toyBuilder.SetBody();
            _toyBuilder.SetLegs();
        }
        public Toy GetToy()
        {
            return _toyBuilder.GetToy();
        }
    }
   
}

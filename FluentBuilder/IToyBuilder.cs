using System;

namespace FluentBuilder
{
    public interface IToyBuilder
    {
        IToyBuilder SetModel();
        IToyBuilder SetHead();
        IToyBuilder SetLimbs();
        IToyBuilder SetBody();
        IToyBuilder SetLegs();
        IToyBuilder SetWheels();
        Toy GetToy();
    }

    public class Toy
    {
        public string Model { get; set; }
        public string Head { get; set; }
        public string Limbs { get; set; }
        public string Body { get; set; }
        public string Legs { get; set; }
        public string Wheels { get; set; }
    }

    public class PremiumToyBuilder : IToyBuilder
    {
        Toy toy = new Toy();
        public IToyBuilder SetModel()
        {
            toy.Model = "TOY A";
            return this;
        }
        public IToyBuilder SetHead()
        {
            toy.Head = "1";
            return this;
        }
        public IToyBuilder SetLimbs()
        {
            toy.Limbs = "4";
            return this;
        }
        public IToyBuilder SetBody()
        {
            toy.Body = "Plastic";
            return this;
        }
        public IToyBuilder SetLegs()
        {
            toy.Legs = "2";
            return this;
        }
        public Toy GetToy()
        {
            return toy;
        }

        public IToyBuilder SetWheels()
        {
            toy.Wheels = "4 Wheels";
            return this;
        }
    }

    public class RegularToyBuilder : IToyBuilder
    {
        Toy toy = new Toy();
        public IToyBuilder SetModel()
        {
            toy.Model = "TOY B";
            return this;
        }
        public IToyBuilder SetHead()
        {
            toy.Head = "1";
            return this;
        }
        public IToyBuilder SetLimbs()
        {
            toy.Limbs = "4";
            return this;
        }
        public IToyBuilder SetBody()
        {
            toy.Body = "Steel";
            return this;
        }
        public IToyBuilder SetLegs()
        {
            toy.Legs = "4";
            return this;
        }
        public Toy GetToy()
        {
            return toy;
        }
        public IToyBuilder SetWheels()
        {
            toy.Wheels = "2 Wheels";
            return this;
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
            _toyBuilder.SetModel().SetHead().SetLimbs().SetBody()
                .SetLegs().SetWheels();
        }
        public void CreateMVPToy()
        {
            _toyBuilder.SetModel().SetHead().SetLimbs()
            .SetBody().SetLegs();
        }
        public Toy GetToy()
        {
            return _toyBuilder.GetToy();
        }
    }

    public class fluentBuildere { }
}

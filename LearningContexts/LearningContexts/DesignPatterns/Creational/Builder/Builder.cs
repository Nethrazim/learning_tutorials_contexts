using LearningContexts.DesignPatterns.Creational.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningContexts.DesignPatterns.Creational.Builder
{
    public class Product
    {
        public string Part1 { get; set; }
        public string Part2 { get; set; }
        public string Part3 { get; set; }

        public override string ToString()
        {
            return $"{ Part1 + " " + Part2 + " " + Part3 }";
        }
    }

    public interface IBuilder
    {
        void BuildPart1();
        void BuildPart2();
        void BuildPart3();
        Product GetProduct();
    }

    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public void BuildPart1()
        {
            _product.Part1 = "Part 1";
        }

        public void BuildPart2()
        {
            _product.Part2 = "Part 2";
        }

        public void BuildPart3()
        {
            _product.Part3 = "Part 3";
        }

        public Product GetProduct()
        {
            return _product;
     
        }
    }

    public class Director
    {
        IBuilder _builder;
        public void Construct(IBuilder iBuilder)
        {
            _builder = iBuilder;
            iBuilder.BuildPart1();
            iBuilder.BuildPart2();
            iBuilder.BuildPart3();
        }

        public Product GetProduct()
        {
            return _builder.GetProduct();
        }
    }

    public class Builder
    {
        public static void Run()
        {
            Director d = new Director();
            d.Construct(new ConcreteBuilder());
            Product p = d.GetProduct();
            Console.WriteLine(p.ToString());
        }
    }
}

﻿using System;

namespace PerguntaValores {

    class Cylinder {
        
        private const double Pi = 3.1415926;
        private double _height = 0;
        private double _ray = 0;
        private double Volume => Pi * Math.Pow(_ray, 2) * _height; //π * pow(r) * h
        private double SurfaceArea => 2 * Pi * _ray * (_ray + _height); // 2πr(r + h) 
        
        public Cylinder(double height, double ray) {
            this._height = height;
            this._ray = ray;
        }
        
        public override string ToString() {
            return $"height: {_height} \n" +
                   $"ray: {_ray} \n" +
                   $"volume: {Volume} \n" +
                   $"surface area: {SurfaceArea}";
        }
    }
    
    class Exec {
        static void Main(string[] args) {
            
            Console.Write("\ninsert height: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("insert ray: ");
            double ray = double.Parse(Console.ReadLine());

            Cylinder cylinder = new Cylinder(height, ray);
            Console.WriteLine("\n" + cylinder.ToString());
            
        }
    }
    
}
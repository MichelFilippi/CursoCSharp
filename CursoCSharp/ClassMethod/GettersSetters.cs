using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassMethod {
    internal class GettersSetters {
        public class Bike {
            private string Brand;
            private string Model;
            private int CubicC;

            public Bike(string brand, string model, int cubicC) {
                //Brand = brand;
                //Model = model;
                //CubicC = cubicC;
                SetBrand(brand);
                SetModel(model);
                SetCubicC(cubicC);
            }
            public Bike() {


            }
            public string GetBrand() {
                return Brand;
            }

            public void SetBrand(string brand) {
                Brand = brand;
            }
            public string GetModel() {
                return Model;
            }
            public void SetModel(string model) {
                Model = model;
            }
            public int GetCubicC() {
                return CubicC;
            }
            public void SetCubicC(int cubicC) {
                //if(cubicC > 0) {
                //     CubicC = cubicC;

                //}
                CubicC = Math.Abs(cubicC);
            }



        }

        public static void Execute() {

            var bike1 = new Bike("BMW","Modelo 2022", -600);

            Console.WriteLine(bike1.GetBrand());
            Console.WriteLine(bike1.GetModel());
            Console.WriteLine(bike1.GetCubicC());


            var bike2 = new Bike();
            bike2.SetBrand("Fiat");
            bike2.SetModel("2020");
            bike2.SetCubicC(500);

            Console.WriteLine(bike2.GetBrand());
            Console.WriteLine(bike2.GetModel());
            Console.WriteLine(bike2.GetCubicC());





        }
    }
}

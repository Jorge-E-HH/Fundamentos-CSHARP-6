using FundamentosCSHARP.Models;
using FundamentosCSHARP3.Models;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;


namespace FundamentosCSHARP3
{
    class Program
    {
        static void Main(string[] args)
        {
            CervezaBD cervezaBD = new CervezaBD();



            // insertamos nueva cerveza
            /*{
                Cerveza cerveza = new Cerveza(15, "Pale_ale");
                cerveza.Marca = "Minerva";
                cerveza.Alcohol = 6;
                cervezaBD.Add(cerveza);
            } */
            {
              
                cervezaBD.Delete(5);
            }



            // obtener todas las cervezas
            var cervezas = cervezaBD.Get();


            foreach (var cerveza in cervezas)
            {
                Console.WriteLine(cerveza.Nombre);

            }
        }



    }
}
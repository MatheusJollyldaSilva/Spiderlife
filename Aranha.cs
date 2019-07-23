using System;
using System.Collections.Generic;

namespace Exemplo_poo_matheus
{
    public class Pata 
    {   
        public Pata(){

        }
        public void Cocar()
        {
            Console.WriteLine("Conçando...");
        }
    }
    public abstract class Aranha {
        public List<Pata> Patas { get; set; }
        public string Corpo { get; set; }
        public int Olhos { get; set; }
        public int Prezas { get; set; }
        public int Veneno { get; set; }

        public Aranha(int patas, string corpo, int olhos, int prezas, int veneno){
            
            Patas = new List<Pata>();
            for (int i = 0; i < patas; i++)
            {
            
                Patas.Add(new Pata());
            }

            Corpo = corpo;
            Olhos = olhos;
            Prezas = prezas;
            Veneno = veneno;
        }

        public void InjetarVeneno(int tempo) {
            Veneno = Veneno - tempo;
            Console.WriteLine("O veneno atual da aranha é  " + Veneno);
        }

        public void Correr(int tempo){
            var velocidade = 2 * tempo;
            Console.WriteLine("A aranha corre a uma velocidade de " + velocidade);
        }

        public void Cocar(int pata)
        {
            Console.WriteLine("Coçando com a pata " + pata);
            this.Patas[pata].Cocar();
        }
    }

    public class Marrom : Aranha
    {
        public Marrom(int patas, string corpo, int olhos, int prezas, int veneno) : base(patas, corpo, olhos, prezas, veneno)
        {
        }

        public void Nadar(int tempo)
        {
            var distancia = tempo * 4 / 3;
            Console.WriteLine("A aranha marrom nada a distancia de " + distancia + " metros");
        }
    }
    public class Tarantula : Aranha
    {
        public Tarantula(int patas, string corpo, int olhos, int prezas, int veneno) : base(patas, corpo, olhos, prezas, veneno)
        {
        }

        public void Pular(int pressao)
        {
            var pulo = pressao * 8 / 2;
            Console.WriteLine("A tarantula pula " + pulo + " centimetros ");
        }
    }
}
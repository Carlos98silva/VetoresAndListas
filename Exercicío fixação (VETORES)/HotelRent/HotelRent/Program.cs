﻿using HotelRent;
using System;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos quartos serão alugados? ");
            int quantidade = int.Parse(Console.ReadLine());

            Rent[] vect = new Rent[10];

            for (int i = 1; i <= quantidade; i++) {
                Console.WriteLine();
                Console.WriteLine("Aluguel #" + i + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Rent(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i <= 9; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
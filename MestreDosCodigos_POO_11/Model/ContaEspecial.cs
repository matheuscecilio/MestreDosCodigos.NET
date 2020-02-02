﻿using MestreDosCodigos_POO_11.Interface;
using System;

namespace MestreDosCodigos_POO_11.Model
{
    public class ContaEspecial : ContaBancaria, IContaBancaria
    {
        public double Limite { get; private set; }

        public ContaEspecial(double limite, double saldo, int numeroConta)
        {
            this.Limite = limite;
            this.Saldo = saldo;
            this.NumeroConta = numeroConta;
        }

        public override void Depositar(double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
            }

            //throw new Exception("Operação Inválida, o valor deve ser maior do que 0!");
        }

        public override void Sacar(double valor)
        {
            var permiteSacar = (this.Saldo + this.Limite) >= valor;
            if (permiteSacar)
            {
                this.Saldo -= valor;
            }

            //throw new Exception("Operação Inválida, o valor desejado ultrapassa seu limite!");
        }

        public void MostraDados()
        {
            Console.WriteLine($"Número da conta: {this.NumeroConta}");
            Console.WriteLine($"Saldo: R$ {this.Saldo}");
            Console.WriteLine($"Limite: R$ {this.Limite}");
            Console.WriteLine();
        }
    }
}
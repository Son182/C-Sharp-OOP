﻿using System;

namespace POO
{
    public abstract class Conta
    {
        int agencia;
        int numeroConta;
        decimal saldo;
        decimal limite;


        public int Agencia
        {
            get { return Agencia; }
            set
            {
                if (value > 0)
                {
                    Agencia = value;
                }
            }
        }

        public int NumeroConta { get => numeroConta; private set => numeroConta = value; }
        public decimal Saldo { get => saldo; private set => saldo = value; }
        public decimal Limite { get => limite; private set => limite = value; }

        public Conta()
        {
            this.limite = 1000;
        }

        public Conta(decimal limite)
        {
            this.limite = limite;
        }

        public void SetAgencia(int agencia)
        {
            this.Agencia = agencia;
        }

        public virtual void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }
    }
}

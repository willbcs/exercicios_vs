﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjClinicaIMC
{
    //internal class ClassesIMC
    //{
    //}
    public interface IExemplo
    {

        public string meuNome();

    }

    [Serializable]

    public class Usuario : Pessoa_fisica, IExemplo, IComparable<Usuario>
    {
        public long hashsenha { get; private set; }
        public string login { get; private set; }
        public char perfil { get; private set; }

        public Usuario(String login) : base("", DateTime.Now, "", '?')
        {
            this.login = login;
            this.perfil = '?';
        }

        public Usuario(
            String nome,
            DateTime dataDeNascimento,
            String cpf,
            char sexo,
            string senha,
            string login,
            char perfil) : base(nome, dataDeNascimento, cpf, sexo)
        {
            this.login = login;
            this.perfil = perfil;
            this.hashsenha = Utilitarios.myHash(senha,"");

        }
        public string meuNome()
        {
            return "Usuário";
        }


        public int CompareTo(Usuario ?u)
        {
            if (u == null) return 1;
            return login.CompareTo(u.login);
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(nome + ",");
            sb.Append(login + ",");
            sb.Append(dataDeNascimento.ToString("dd/MM/yyyy") + ",");
            sb.Append(Utilitarios.formataCpf(cpf) + ",");
            sb.Append(sexo + ",");
            sb.Append(perfil + ",");
            sb.Append(email);


            return sb.ToString();
        }


    }

    [Serializable]

    public class Paciente : Pessoa_fisica, IExemplo, IComparable<Paciente> //paciente e ( : ) subclasse da pessoa fisica
    {
        private IMC imc;

        public int CompareTo(Paciente? x)
        {
            if (x == null)
            {
                return -1;
            }

            return matricula.CompareTo(x.matricula);
        }

        public String matricula { get; private set; }

        public string meuNome()
        {
            return "Paciente";
        }

        public Paciente(string matricula) : base("", new DateTime(), "", '0')
        {
            this.matricula = matricula;
            this.email = "";
            imc = new IMC(0, 0);
        }

        public Paciente(String nome,
            DateTime dataDeNascimento,
            String cpf,
            char sexo,
            float peso,
            float altura, string matricula) : base(nome, dataDeNascimento, cpf, sexo)
        {
            imc = new IMC(peso, altura);
            this.matricula = matricula;
        }

        public float peso()
        {
            return imc.peso;
        }
        public float altura()
        {
            return imc.altura;
        }
        public float valorImc()
        {
            return imc.calculaIMC();
        }
        public override string ToString()
        {
            return $"{nome}, {cpf}, {dataDeNascimento.ToString("dd/MM/yyyy")}, {imc.peso}, {imc.altura}, {matricula}, {email}, {sexo}, {imc.calculaIMC()}, {imc.Diagnostico()}";
        }

    }

    [Serializable]

    public class IMC : Object
    {
        public float peso { get; private set; }
        public float altura { get; private set; }
        public float calculaIMC()
        {
            return peso / (altura * altura);
        }
        public IMC(float peso, float altura)
        {
            this.peso = peso;
            this.altura = altura;

        }
        public string Diagnostico()
        {

            float imc = calculaIMC();

            if (imc < 18.5)
            {
                return "Abaixo do peso";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                return "Peso normal";
            }
            else if (imc >= 25.0 && imc <= 29.9)
            {
                return "Sobrepeso";
            }
            else if (imc >= 30.0 && imc <= 34.9)
            {
                return "Obesidade Grau 1";
            }
            else if (imc >= 35.0 && imc <= 39.9)
            {
                return "Obesidade Grau 2";
            }
            else
            {
                return "Obesidade Grau 3 (Obesidade Mórbida)";
            }
        }

    }

    [Serializable]

    public abstract class Pessoa_fisica
    {
        public String nome { get; private set; }
        public DateTime dataDeNascimento { get; private set; }
        public String cpf { get; private set; }
        public char sexo { get; private set; } //por que usar o (char) com o char pode cadatrar qualquer letra  
        public String email { get; set; }

        protected Pessoa_fisica(String nome, DateTime dataDeNascimento, String cpf, char sexo)
        {
            this.nome = nome;
            this.dataDeNascimento = dataDeNascimento;
            this.cpf = cpf;
            this.sexo = sexo;
            this.email = String.Empty;
        }
    }
}
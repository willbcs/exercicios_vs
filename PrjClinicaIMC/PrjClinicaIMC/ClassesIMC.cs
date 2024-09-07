using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjClinicaIMC
{
    //internal class ClassesIMC
    //{
    //}
    public class Usuario : Pessoa_fisica
    {
        private string senha;
        public string login { get; private set; }
        public char perfil { get; private set; }


        public Usuario(
            String nome,
            DateTime dataDeNascimento,
            String cpf,
            char sexo,
            float altura,
            float peso, string matricula,
            string senha,
            string login,
            char perfil) : base(nome, dataDeNascimento, cpf, sexo)
        {
            this.login = login;
            this.perfil = perfil;
            this.senha = senha;

        }

    }
    public class Paciente : Pessoa_fisica //paciente e ( : ) subclasse da pessoa fisica
    {
        private IMC imc;

        public String matricula { get; private set; }
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
            return $"{nome}, {cpf}, {dataDeNascimento.ToString("dd/MM/yyyy")}, {imc.peso}, {imc.altura}, {matricula}, {email}, {sexo}, {imc.calculaIMC()}";
        }

    }
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

    }
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

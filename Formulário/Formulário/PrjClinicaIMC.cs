using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulário
{
    //internal class ClassesIMC
    //{
    //}
    public class Paciente : Pessoa_fisica //paciente e ( : ) subiclasse da pessoa fisica
    {
        private IMC imc;

        public String matricula { get; private set; }
        public Paciente(String nome,
            DateTime dataDeNacimento,
            String cpf,
            char sexo,
            float altura,
            float peso, string matricula) : base(nome, dataDeNacimento, cpf, sexo)
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
    }
    public class IMC
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
        public DateTime dataDeNacimento { get; private set; }
        public String cpf { get; private set; }
        public char sexo { get; private set; } //por que usar o (char) com o char pode cadatrar qualquer letra  
        public String email { get; set; }

        protected Pessoa_fisica(String nome, DateTime dataDeNacimento, String cpf, char sexo)
        {
            this.nome = nome;
            this.dataDeNacimento = dataDeNacimento;
            this.cpf = cpf;
            this.sexo = sexo;
            this.email = String.Empty;
        }
    }


}

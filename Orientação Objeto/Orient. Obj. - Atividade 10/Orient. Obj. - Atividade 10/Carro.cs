using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orient._Obj.___Atividade_10
{
    internal class Carro
    {
        private string modelo = "", cor = "", marca = "", chassi = "", proprietario = "";
        private int ano = 0, velocidade_max = 100, velocidade_atual = 0, nr_portas = 0, vol_combustivel = 0, nr_marchas = 5;
        private bool teto_solar = false, cambio_auto = false, estado = false;
        private int marcha_atual = 0;

        private void cadastrarVeiculo()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Modelo do Veículo: ");
            Console.WriteLine("--------------------------------------------");
            this.modelo = Console.ReadLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Cor do Véiculo: ");
            Console.WriteLine("--------------------------------------------");
            this.cor = Console.ReadLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Marca do Veículo: ");
            Console.WriteLine("--------------------------------------------");
            this.marca = Console.ReadLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Ano do Veículo:");
            Console.WriteLine("--------------------------------------------");
            this.ano = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Chassi do Veículo: ");
            Console.WriteLine("--------------------------------------------");
            this.chassi = Console.ReadLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Proprietario do Veículo:");
            Console.WriteLine("--------------------------------------------");
            this.proprietario = Console.ReadLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Velocidade Máxima do Veículo: ");
            Console.WriteLine("--------------------------------------------");
            this.velocidade_max = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Número de Portas do Veículo:");
            Console.WriteLine("--------------------------------------------");
            this.nr_portas = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Volume de Combustível do Veículo:");
            Console.WriteLine("--------------------------------------------");
            this.vol_combustivel = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Número de Marchas do Veículo:");
            Console.WriteLine("--------------------------------------------");
            this.nr_marchas = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("O veículo possui teto solar?");
            Console.WriteLine("--------------------------------------------");
            string resposta = Console.ReadLine();
            if (resposta == "Sim" || resposta == "SIM" || resposta == "sim" || resposta == "sIm" || resposta == "SiM")
            {
                this.teto_solar = true;
            }
            else if (resposta == "Não"||resposta == "não" || resposta == "NÃO"|| resposta == "nÃo"|| resposta == "NãO")
            {
                this.teto_solar = false;
            }
            else
            {
                Console.WriteLine("Reposta Não Valida");
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("O veículo possui câmbio automático?");
            Console.WriteLine("--------------------------------------------");
            resposta = Console.ReadLine();
            if (resposta == "Sim" || resposta == "SIM" || resposta == "sim" || resposta == "sIm" || resposta == "SiM")
            {
                this.cambio_auto = true;
            }
            else if (resposta == "Não" || resposta == "não" || resposta == "NÃO" || resposta == "nÃo" || resposta == "NãO")
            {
                this.cambio_auto = false;
            }
            else
            {
                Console.WriteLine("Reposta Não Valida");
            }

        }

        private void exibirFicha()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Modelo do Veículo: " + this.modelo);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Cor do Véiculo: " + this.cor);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Marca do Veículo: "+ this.marca);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Ano do Veículo:" + this.ano);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Chassi do Veículo: "+ this.chassi);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Proprietario do Veículo:"+ this.proprietario);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Velocidade Máxima do Veículo: "+ this.velocidade_max);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Número de Portas do Veículo:" + this.nr_portas);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Volume de Combustível do Veículo:"+ this.vol_combustivel);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Número de Marchas do Veículo:"+ this.nr_marchas);
            Console.WriteLine("--------------------------------------------");
            string resposta;
            if (teto_solar == true)
            {
                resposta = "Sim, Possui";
            }
            else
            {
                resposta = "Não, Não Possui";
            }
            Console.WriteLine("O veículo possui teto solar? "+ resposta);
            Console.WriteLine("--------------------------------------------");
            if (cambio_auto == true)
            {
                resposta = "Sim, Possui";
            }
            else
            {
                resposta = "Não, Não Possui";
            }
            Console.WriteLine("O veículo possui câmbio automático? " + resposta);
            Console.WriteLine("--------------------------------------------");
        }


        public void colsultarPainel()
        {
            string painel;
            while (true)
            {
                if (estado == true)
                {
                    painel = "Ligado";
                }
                else
                {
                    painel = "Desligado";
                }
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Veículo: "+ painel);
                Console.WriteLine("Velocidade Atual: "+ this.velocidade_atual);
                Console.WriteLine("Marcha Atual: "+this.marcha_atual);
                Console.WriteLine("--------------------------------------------");
                Console.Write(" 1) Ligar/Desligar. \n 2) Acelerar. \n 3) Freiar. \n 4) Trocar Marcha. \n 5) Diminuir Marcha. \n 6) Sair do Veículo. \n 7) Cadastrar Veículo. \n 8) Exibir Ficha. \n");
                Console.WriteLine("--------------------------------------------");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        ligar();
                        break;
                    case 2:
                        acelerar();
                        break;
                    case 3:
                        desacelerar();
                        break;
                    case 4:
                        trocarMarcha();
                        break;
                    case 5:
                        diminuirMarcha();
                        break;
                    case 6:
                        break;
                    case 7:
                        cadastrarVeiculo();
                        break;
                    case 8:
                        exibirFicha();
                            break;
                    default:
                        Console.WriteLine("Opção Ínvalida.");
                        break;

                }
            }   
        }

        private void ligar()
        {
            if (this.estado == true)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("O veículo está Ligado, o desligando");
                Console.WriteLine("--------------------------------------------");
                this.estado = false;
            }
            else
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("O veículo está Desligado, o Ligando");
                Console.WriteLine("--------------------------------------------");
                this.estado = true;
            }
        }

        private void acelerar()
        {
            Console.WriteLine("--------------------------------------------");
            if (this.estado == true)
            {
                if (marcha_atual == 1)
                {
                    if (this.velocidade_atual <= 20)
                    {
                        this.velocidade_atual = this.velocidade_atual + 1;
                    }
                    else
                    {
                        Console.WriteLine("O veículo está no limite da Velocidade da marcha: " + this.velocidade_max);
                    }
                }
                else if (marcha_atual == 2)
                {
                    if (this.velocidade_atual <= 30)
                    {
                        this.velocidade_atual = this.velocidade_atual + 1;
                    }
                    else
                    {
                        Console.WriteLine("O veículo está no limite da Velocidade da marcha: " + this.velocidade_max);
                    }
                }
                else if (marcha_atual == 3)
                {
                    if (this.velocidade_atual <= 50)
                    {
                        this.velocidade_atual = this.velocidade_atual + 1;
                    }
                    else
                    {
                        Console.WriteLine("O veículo está no limite da Velocidade da marcha: " + this.velocidade_max);
                    }
                }
                else if (marcha_atual == 4)
                {
                    if (this.velocidade_atual <= 80)
                    {
                        this.velocidade_atual = this.velocidade_atual + 1;
                    }
                    else
                    {
                        Console.WriteLine("O veículo está no limite da Velocidade da marcha: " + this.velocidade_max);
                    }
                }
                else if (marcha_atual == 5)
                {
                    if (this.velocidade_atual <= this.velocidade_max)
                    {
                        this.velocidade_atual = this.velocidade_atual + 1;
                    }
                    else
                    {
                        Console.WriteLine("O veículo está no limite da Velocidade da marcha: " + this.velocidade_max);
                    }
                }
                else
                {
                    Console.WriteLine("O carro está em ponto neutro, por isso não pode ser acelerado");
                }
            }
            else
            {
                Console.WriteLine("O carro deve estar ligado e com alguma das marchas engatadas para ser acelerado");
            }
        }

        private void desacelerar()
        {
            Console.WriteLine("--------------------------------------------");
            if (this.estado == true)
            {
                if (this.marcha_atual == 1 && this.velocidade_atual > 0)
                {
                    if (this.velocidade_atual <= 20)
                    {
                        this.velocidade_atual = this.velocidade_atual + 1;
                    }
                    else
                    {
                        Console.WriteLine("O veículo está no limite da Velocidade da marcha: " + this.velocidade_atual);
                    }
                }
                else if (this.marcha_atual == 2 && this.velocidade_atual > 0)
                {
                    if (this.velocidade_atual <= 30)
                    {
                        this.velocidade_atual = this.velocidade_atual + 1;
                    }
                    else
                    {
                        Console.WriteLine("O veículo está no limite da Velocidade da marcha: " + this.velocidade_atual);
                    }
                }
                else if (this.marcha_atual == 3 && this.velocidade_atual > 0)
                {
                    if (this.velocidade_atual <= 50)
                    {
                        this.velocidade_atual = this.velocidade_atual + 1;
                    }
                    else
                    {
                        Console.WriteLine("O veículo está no limite da Velocidade da marcha: " + this.velocidade_atual);
                    }
                }
                else if (this.marcha_atual == 4 && this.velocidade_atual > 0)
                {
                    if (this.velocidade_atual <= 80)
                    {
                        this.velocidade_atual = this.velocidade_atual - 1;
                    }
                    else
                    {
                        Console.WriteLine("O veículo está no limite da Velocidade da marcha: " + this.velocidade_atual);
                    }
                }
                else if (this.marcha_atual == 5 && this.velocidade_atual > 0)
                {
                    if (this.velocidade_atual <= this.velocidade_max)
                    {
                        this.velocidade_atual = this.velocidade_atual - 1;
                    }
                    else
                    {
                        Console.WriteLine("O veículo está no limite da Velocidade da marcha: " + this.velocidade_atual);
                    }
                }
                else
                {
                    Console.WriteLine("O carro está em ponto neutro, por isso não pode ser acelerado");
                }
            }
            else
            {
                Console.WriteLine("O carro deve estar ligado e com alguma das marchas engatadas para ser acelerado");
            }
        }

        private void trocarMarcha()
        {
            if (this.estado == true)
            {
                if (this.marcha_atual >= 0 && this.marcha_atual <= this.nr_marchas)
                {
                    this.marcha_atual = this.marcha_atual + 1;
                }
            }
            else
            {
                Console.WriteLine("O veículo deve estar ligado para trocar as marchas.");
            }
        }

        private void diminuirMarcha()
        {
            if (this.estado == true)
            {
                if (this.marcha_atual >= 0 && this.marcha_atual <= this.nr_marchas)
                {
                    this.marcha_atual = this.marcha_atual - 1;
                }
            }
            else
            {
                Console.WriteLine("O veículo deve estar ligado para trocar as marchas.");
            }
        }

        private void sairVeículo()
        {
            System.Environment.Exit(0);
        }


    }
}

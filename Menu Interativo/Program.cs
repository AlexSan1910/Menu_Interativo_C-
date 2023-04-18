namespace Course{
    class Program{
        static void Main(string[] args){
            bool exibirMenu = true;
            while(exibirMenu == true){
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Buscar Cliente");
                Console.WriteLine("3 - Apagar Cliente");
                Console.WriteLine("4 - Encerrar");

                string opcao = Console.ReadLine();

                switch(opcao){
                    case "1":
                        Console.WriteLine("Cadastro de Cliente!");
                        break;

                    case "2":
                        Console.WriteLine("Busca de Cliente");
                        break;

                    case "3":
                        Console.WriteLine("Apagar Cliente");
                        break;

                    case "4":
                        Console.WriteLine("encerrar");
                        exibirMenu = false; // se clicar na opção 4, irá colocar como false!
                        break;

                    default: // uma opção se caso nenhuma outra estiver enquadrado com o que o usuario digitou
                        Console.WriteLine("Opção invalida!");
                        break;
                }
            }
        }
    }
}
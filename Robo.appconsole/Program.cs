namespace Robo.appconsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] grid = new double[5, 5];

            int posicaoY = 0;
            int posicaoX = 0;
            char direcaoRobo = ' ';

            int posicaoYDois = 0;
            int posicaoXDois = 0;
            char direcaoRoboDois = ' ';

            Console.WriteLine("5 5");

            Console.WriteLine("Digite a posição inicial primeiro robo:");
            string posicao = Console.ReadLine();

            string[] posicaoRobo = posicao.ToUpper().Split(" ");
            posicaoX = int.Parse(posicaoRobo[0]);
            posicaoY = int.Parse(posicaoRobo[1]);
            direcaoRobo = char.Parse(posicaoRobo[2]);

            Console.WriteLine("Digite os movimentos do primeiro robo: ");
            string comando = Console.ReadLine();

            Console.WriteLine("Digite a posição inicial segundo robo:");
            string posicaoDois = Console.ReadLine();

            string[] posicaoRoboDois = posicaoDois.ToUpper().Split(" ");
            posicaoXDois = int.Parse(posicaoRoboDois[0]);
            posicaoYDois = int.Parse(posicaoRoboDois[1]);
            direcaoRoboDois = char.Parse(posicaoRoboDois[2]);

            Console.WriteLine("Digite os movimentos do segundo robo: ");

            string comandoDois = Console.ReadLine();

            char[] comandoQuebrado = new char[100];
            comandoQuebrado = comando.ToUpper().ToCharArray();

            char[] comandoQuebradoDois = new char[100];
            comandoQuebradoDois = comandoDois.ToUpper().ToCharArray();

            for (int i = 0; i < comandoQuebrado.Length; i++)
            {

                if (comandoQuebrado[i] != null)
                {

                    switch (comandoQuebrado[i])
                    {
                        case 'M':
                            if (direcaoRobo == 'N')
                            {
                                if (posicaoY < 5) posicaoY++;
                            }
                            else if (direcaoRobo == 'S')
                            {
                                if (posicaoY > 0) posicaoY--;
                            }
                            else if (direcaoRobo == 'O')
                            {
                                if (posicaoX > 0) posicaoX--;
                            }
                            else if (direcaoRobo == 'L')
                            {
                                if (posicaoX < 5) posicaoX++;
                            }
                            break;

                        case 'E':
                            if (direcaoRobo == 'N')
                            {
                                direcaoRobo = 'O';
                            }
                            else if (direcaoRobo == 'S')
                            {
                                direcaoRobo = 'L';
                            }
                            else if (direcaoRobo == 'L')
                            {
                                direcaoRobo = 'N';
                            }
                            else if (direcaoRobo == 'O')
                            {
                                direcaoRobo = 'S';
                            }
                            break;

                        case 'D':
                            if (direcaoRobo == 'N')
                            {
                                direcaoRobo = 'L';
                            }
                            else if (direcaoRobo == 'S')
                            {
                                direcaoRobo = 'O';
                            }
                            else if (direcaoRobo == 'L')
                            {
                                direcaoRobo = 'S';
                            }
                            else if (direcaoRobo == 'O')
                            {
                                direcaoRobo = 'N';
                            }
                            break;

                    }
                }
            }
        }
    }
}

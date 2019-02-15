using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrezidentoRinkimai
{
    internal class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            string path = null;
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = ofd.FileName;
            }
            System.IO.StreamReader reader = new System.IO.StreamReader(path);
            string kandidatai = reader.ReadLine();
            string[] kandidatuMasyvas = kandidatai.Split(' ');
            int max = int.MinValue;
            int maxIndex = -1;
            for (int i = 0; i < kandidatuMasyvas.Length; i++)
            {
                var raides = kandidatuMasyvas[i].ToCharArray();
                int unikaliosRaides = UnikaliuRadziuKiekis(raides);
                if (max < unikaliosRaides)
                {
                    maxIndex = i;
                    max = unikaliosRaides;
                }
            }
            Console.WriteLine("Prezidento rinkimus laimejo: " + kandidatuMasyvas[maxIndex]);
        }

        public static int UnikaliuRadziuKiekis(char[] raides)
        {
            int UnikaliuRaidziuKiekis = 0;
            for (int i = 0; i < raides.Length; i++)
            {
                bool pozymis = true;
                for (int j = i + 1; j < raides.Length; j++)
                {
                    if (raides[i] == raides[j])
                    {
                        pozymis = false;
                        break;
                    }
                }
                if (pozymis)
                {
                    UnikaliuRaidziuKiekis++;
                }
            }
            return UnikaliuRaidziuKiekis;
        }
    }
}
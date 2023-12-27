using System.Diagnostics;
using System.Text;

namespace Lesson01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập xuất với c#");
            int a = 1;
            int b = 9;
            int c = a + b;
            Console.WriteLine("{0}+{1}={2}",a,b,c);
            Console.WriteLine("{2} = {0}+{1}", a,b,c);
            //// nhập read/readLine
            //string name;
            //int age;
            //Console.WriteLine("nhạp tên");
            //name = Console.ReadLine();
            //Console.WriteLine("nhập tuổi:");
            //// age=Convert.ToInt32(Console.Read());
            //age = int.Parse(Console.ReadLine());
            //Console.WriteLine("welcometo {0}, {1} tuổi",name,age);

            // Ép kiểu
            double x = 10.56;
            int y = (int)x;
            Console.WriteLine(x);
            Console.WriteLine("ép kiểu double sang int {0}",y);

            // cấu trúc if
            //---------- if đơn
            Console.WriteLine("nhập vào 1 số:");
            int n = int.Parse(Console.ReadLine());
            if (n > 10)
            {
                Console.Write("{0} >10",n);
            }
            // if else
            if (n % 2 == 0)
            {

                Console.WriteLine("chẵn");
            }
            else {
                Console.WriteLine("lẻ");
            }
            // if else if
            if(n > 0)
            {
                Console.WriteLine("Dương");
            }else if(n == 0)
            {
                Console.WriteLine("=0");
            }
            else
            {
                Console.WriteLine("Âm"); 
            }
            // số ,b giải ptrinh bậc nhất với hệ sống input input1 x + input2
            //Console.WriteLine("Nhập a:");
            //float input1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Nhập b:");
            //float input2 = float.Parse(Console.ReadLine());
            //float z;
            //if (input1 > 0) {
            //    if (input2 != 0)
            //    {
            //        z = (float)-input2 / input1;
            //        Console.WriteLine("a>0 & b>0 nghiệm của ptrinh: {0}", z);
            //    }
            //    else
            //    {
            //        Console.WriteLine("a>0; b<0 nghiệm = 0");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("a<0 pt ko có nghiệm");
            //}


            // switch key
            // nhập 1 số (1 chữ số) đọc thành lời việt
            int num;
            Console.WriteLine("num=:");
            num = int.Parse(Console.ReadLine());
            //switch(num){
            //    case 0: Console.WriteLine("không"); break;
            //    case 1: Console.WriteLine("một"); break;
            //    case 2: Console.WriteLine("hai"); break;
            //    case 3: Console.WriteLine("ba"); break;
            //    case 4: Console.WriteLine("Bốn"); break;
            //    case 5: Console.WriteLine("Năm"); break;
            //    case 6: Console.WriteLine("Sáu"); break;
            //    case 7: Console.WriteLine("Bảy"); break;
            //    case 8: Console.WriteLine("Tám"); break;
            //    case 9: Console.WriteLine("Chín"); break;
            //    default : Console.WriteLine("Chưa đc lập trình");break;


            //}
            //for int ra 0-10
            for(int i = 0; i < num; i++) {
                Console.WriteLine(i);
            }
            // while
            bool x1 = true;
            while (x1 = !x1)
            {
                Console.WriteLine(x1);
            }

        }
    }
}
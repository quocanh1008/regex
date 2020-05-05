using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace regex
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex RE = new Regex(@"(?<times>(\d|:)+)\s" + @"(?<company>\S+)\s" + @"(?<ip>(\d|\.)+)\s" + @"(?<company>\S+)");
            foreach (Match item in RE.Matches("10:30:15 IBM 192.168.1.2 INTEL"))
            {
                Console.WriteLine(" time: " + item.Groups["times"]);
                Console.WriteLine(" ip: " + item.Groups["ip"]);
                Console.Write(" company: ");
                /*
                    Lấy ra tất cả các capture bắt được trong group company và duyệt lần lượt chúng
                 * Sau đó ta có thể sử dụng hàm ToString() hoặc thuộc tính Value để lấy giá trị của Capture
                 */
                foreach (Capture i in item.Groups["company"].Captures)
                {
                    Console.Write(i.ToString() + " ");
                }

            }
            Console.ReadKey();
        }
    }
}

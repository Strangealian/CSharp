#define PI
#define DEBUG
using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
using IndexersSamples.Common;
namespace TestConsoleApplication
{
    class Test
    {
        public void NullTest()
        {
            int? test = null;
            test = 100;
            Console.WriteLine(test);
        }
        public void ArrayTest()
        {
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            foreach (int temp in array1)
            {
                Console.WriteLine(temp);
            }
            return;
        }
        public void StringTest()
        {
            System.String s = "hello this is a test string";
            Console.WriteLine(s.Length);
            // Console.WriteLine();
            return;
        }
        struct book
        {
            public string name;
            public string id;
            public string author;
        }
        public void StructTest()
        {
            book book1;
            book1.name = "C#开发指南";
            book1.id = "2029";
            book1.author = "xin";

            return;
        }
    }
    class ConstructTest
    {
        private int a;
        public ConstructTest()
        {
            Console.WriteLine("构造函数调用");
        }

        public void SetA(int x)
        {
            this.a = x;
            return;
        }
        ~ConstructTest()
        {
            Console.WriteLine("析构函数调用");
        }
    }


    class Line
    {
        private double length;   // 线条的长度
        public Line()  // 构造函数
        {
            Console.WriteLine("对象已创建");
        }
        ~Line() //析构函数
        {
            Console.WriteLine("对象已删除");
        }

        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }
    }

    class Rectangle
    {
        private double length;
        private double width;
        public Rectangle(double l, double w)
        {
            this.length = l;
            this.width = w;
        }
        public double getArea()
        {
            return this.width * this.length;
        }


    }
    public interface CostCalculator
    {
        public double GetCost(double x);
    }
    class Taplap : Rectangle, CostCalculator
    {
        private double cost;
        public Taplap(double l, double w) : base(l, w)
        {
        }
        public void SetCost(double x)
        {
            this.cost = x;
        }
        public double GetCost(double x)
        {
            Console.WriteLine(base.getArea());
            return this.cost * this.getArea();
        }
    }

    class AddTest
    {
        public double add(double a, double b) => a + b;
        public double add(double a, double b, double c) => a + b + c;
    }
    abstract class Shape
    {
        abstract public double area();
    }
    class ShapeRectangle : Shape
    {
        private double height;
        private double width;
        public ShapeRectangle(double a, double b)
        {
            this.Height = a;
            this.Width = b;
        }

        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }

        public override double area()
        {
            return Height * Width;
        }
    }

    //运算符重载
    class Box
    {
        private double width;
        private double height;

        public Box()
        {
        }
        public Box(double a, double b)
        {
            this.width = a;
            this.height = b;
        }

        public double GetHeight()
        {
            return height;
        }

        public void SetHeight(double value)
        {
            height = value;
        }

        public double GetWidth()
        {
            return width;
        }

        public void SetWidth(double value)
        {
            width = value;
        }

        public static Box operator +(Box a, Box b)
        {
            Box box = new Box();
            box.width = a.width + b.width;
            box.height = a.height + b.height;
            return box;
        }
        public override string ToString()
        {
            return String.Format("Height:{0},Width:{1}", this.GetHeight(), this.GetWidth());
        }
    }

    class DefineTest
    {
        public void IfDefineTest()
        {
            //#warning "this is a define test program"
            //#error "this is a error test program"
#if (PI)
            Console.WriteLine("PI is defined");
#else
            Console.WriteLine("PI is not defined");
#endif
        }
    }

    class RegulationTest
    {
        public void RegulationTestMethod()
        {
            string str1 = "hello this is a test regulation string";
            string pattern = @"[a-g]";
            foreach (Match item in Regex.Matches(str1, pattern))
            {
                Console.Write(item);
            }
        }
    }

    class ExceptionTest
    {
        public void ExceptionTestMethod(int? a, int? b)
        {
            double c = 0;
            try
            {
                c = (double)(a / b);
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }
    }

    class FileStreamTest
    {
        public void FileStreamTestMethod()
        {
            string path = @"C:\Users\0380009604\Desktop\study\MyTest.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (FileStream f = File.Create(path))
            {
                AddText(f, "hello\n");
                AddText(f, "this is a test file\n");
            }

            //read the file and write it to console window
            using (FileStream f = File.OpenRead(path))
            {
                UTF8Encoding temp = new UTF8Encoding(true);
                byte[] b = new byte[1024];
                while (f.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                }
            }
        }
        // [Obsolete("this is a outdate method")]
        //[Conditional("DEBUG")]
        [DebugInfo(1001, "xin", "xin", "this is a test DebugInfo")]
        private static void AddText(FileStream f, string s)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(s);
            f.Write(info, 0, info.Length);
        }
    }


    public class DebugInfo : System.Attribute
    {
        private int bugNo;
        private string? developer;
        private string? lastReview;
        private string? bugInfo;

        public DebugInfo(int bugNo, string? developer, string? lastReview, string? bugInfo)
        {
            this.bugInfo = bugInfo;
            this.developer = developer;
            this.lastReview = lastReview;
            this.bugInfo = bugInfo;
        }

        public int BugNo { get => bugNo; set => bugNo = value; }
        public string? Developer { get => developer; set => developer = value; }
        public string? LastReview { get => lastReview; set => lastReview = value; }
        public string? BugInfo { get => bugInfo; set => bugInfo = value; }
    }

    public abstract class Person
    {
        public abstract string name { get; set; }
        public abstract string age { get; set; }
    }
    public class Chinese : Person
    {
        public override string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }

    }

    //索引器测试程序
    public class DataSamples
    {
        private class Page
        {
            private readonly List<Measurements> pageData = new List<Measurements>();
            private readonly int startingIndex;
            private readonly int length;
            private bool dirty;
            private DateTime lastAccess;

            public Page(int startingIndex, int length)
            {
                this.startingIndex = startingIndex;
                this.length = length;
                lastAccess = DateTime.Now;

                // This stays as random stuff:
                var generator = new Random();
                for (int i = 0; i < length; i++)
                {
                    var m = new Measurements
                    {
                        HiTemp = generator.Next(50, 95),
                        LoTemp = generator.Next(12, 49),
                        AirPressure = 28.0 + generator.NextDouble() * 4
                    };
                    pageData.Add(m);
                }
            }
            public bool HasItem(int index) =>
                ((index >= startingIndex) &&
                (index < startingIndex + length));

            public Measurements this[int index]
            {
                get
                {
                    lastAccess = DateTime.Now;
                    return pageData[index - startingIndex];
                }
                set
                {
                    pageData[index - startingIndex] = value;
                    dirty = true;
                    lastAccess = DateTime.Now;
                }
            }

            public bool Dirty => dirty;
            public DateTime LastAccess => lastAccess;
        }

        private readonly int totalSize;
        private readonly List<Page> pagesInMemory = new List<Page>();

        public DataSamples(int totalSize)
        {
            this.totalSize = totalSize;
        }

        public Measurements this[int index]
        {
            get
            {
                if (index < 0)
                    throw new IndexOutOfRangeException("Cannot index less than 0");
                if (index >= totalSize)
                    throw new IndexOutOfRangeException("Cannot index past the end of storage");

                var page = updateCachedPagesForAccess(index);
                return page[index];
            }
            set
            {
                if (index < 0)
                    throw new IndexOutOfRangeException("Cannot index less than 0");
                if (index >= totalSize)
                    throw new IndexOutOfRangeException("Cannot index past the end of storage");
                var page = updateCachedPagesForAccess(index);

                page[index] = value;
            }
        }

        private Page updateCachedPagesForAccess(int index)
        {
            foreach (var p in pagesInMemory)
            {
                if (p.HasItem(index))
                {
                    return p;
                }
            }
            var startingIndex = (index / 1000) * 1000;
            var newPage = new Page(startingIndex, 1000);
            addPageToCache(newPage);
            return newPage;
        }

        private void addPageToCache(Page p)
        {
            if (pagesInMemory.Count > 4)
            {
                // remove oldest non-dirty page:
                var oldest = pagesInMemory
                    .Where(page => !page.Dirty)
                    .OrderBy(page => page.LastAccess)
                    .FirstOrDefault();
                // Note that this may keep more than 5 pages in memory
                // if too much is dirty
                if (oldest != null)
                    pagesInMemory.Remove(oldest);
            }
            pagesInMemory.Add(p);
        }
    }

    //委托测试程序
    delegate int DelegateMethod(int a,int b);
    public class DelegateTest
    {
        public int Add(int a,int b)
        {
            return a+b;
        }
        public int Multiply(int a,int b)
        {
            return a*b;
        }

        public void DelegateTestMethod()
        {
            DelegateMethod m1=new DelegateMethod(Add);
            DelegateMethod m2=new DelegateMethod(Multiply);
            Console.WriteLine(m1(10,20));
            Console.WriteLine(m2(10,20));
        }
    }

}
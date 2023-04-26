#define PI
#define Trace

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using First;
using First.Second;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.Collections;
using System.Threading;

delegate int NumberChanger(int n); //定義委託

//using Second;

namespace ConsoleApplication1
{

    //定義泛型類
    class GeneriClass<T> {
        //泛型方法
        public GeneriClass(T msg) {
            Console.WriteLine(msg);
        }
    }

    struct books

    {
        public string title, author;
        public string subject;
        public int book_id;

        public void getValue(string t, string a, string s, int id)
        {
            title = t;
            author = a;
            //subject = s;
            //book_id = id;
        }

        //public void disPlay()
        //{
        //    Console.WriteLine("Title: {0}", title);
        //    Console.WriteLine("author: {0}", author);
        //    Console.WriteLine("subject: {0}", subject);
        //    Console.WriteLine("book_id: {0}", book_id);
        //}
    }
    class BaseTest
    {
        public int a = 22;
        protected int b = 2;
    }

    //基類
    class Shape
    {
        protected int width, height;
        public void setWidth(int w)
        {
            width = w;
        }

        public void setHeight(int h)
        {
            height = h;
        }
    }

    //定義接口
    //public interface Perimeter {
    //    int getGirth();
    //}

    //派生類
    //class Rectangle : Shape, Perimeter{
    class Rectangle : Shape
    {
        public int getArea() {
            return width * height;
        }
        public int getGirth() {
            return (width + height) * 2;
        }
    }

    //派生類
    /*class Rectangle : Shape
    {
        public int getArea()
        {
            return width * height;
        }
    }*/

    //abstract class Shape {
    //    public abstract int area();

    //}

    //class Rectangle : Shape {
    //    private int width, height;
    //    public  Rectangle(int w, int h) {
    //        width = w;
    //        height = h;
    //    }

    //    public override int area() {
    //        return (width * height);
    //    }
    //}

    class Box {
        private double length;
        private double breadth;
        private double height;

        public double getVolume() {
            return length * breadth * height;
        }

        public void setLength(double len) {
            length = len;
        }

        public void setBreadth(double bre) {
            breadth = bre;
        }

        public void setHeight(double hei) {
            height = hei;
        }

        public static Box operator +(Box b, Box c) {
            Box box = new Box();

            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }
    }

    public interface Iwebsite
    {
        void setValue(string str1, string str2);
        void disPlay();
    }



    public class Website : Iwebsite
    //public class Website
    {
        public string name, ur1;
        public void setValue(string n, string u)
        {
            name = n;
            ur1 = u;
        }
        public void disPlay()
        {
            Console.WriteLine("{0} {1}", name, ur1);
        }
    }
    public interface IParentInterface {
        void ParentInterfaceMethod();
    }

    public interface IMyInterface : IParentInterface {
        void MethodToImplement();
    }

    public class InvalidAgeException : ApplicationException {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }

    public class TestUserDefinedException {
        public void validata(int age) {
            if (age < 18) {
                throw (new InvalidAgeException("Sorry,age must be greater than 18"));
            } }
    }

    public class Myclass
    {
       // [Conditional("Debug")]
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    class Student {
        private string code = "N.A";
        private string name = "not known";
        private int age = 0;
        private string love = "not known";

        //聲明類型為 string 的 code 屬性
        public string Code {
            get {
                return code;
            }
            set {
                code = value;
            }
        }

        //聲明類型為 string 的 Name 屬性
        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        //聲明類型為 int 的 Age 屬性
        public int Age {
            get {
                return age;
            }
            set {
                age = value;
            }
        }

        //聲明類型為 string 的Love 屬性
        public string Love {
            get {
                return love;
            }
            set {
                love = value;
            }
        }

    

        public override string ToString()
        {
         
                return "編號 = " + Code + ",姓名 = " + Name + ",年齡 =" + Age + ",喜歡 =" + Love;
            
        }
    }

    public abstract class Person
    {
        public abstract string Name
        {
            get;
            set;
        }
        public abstract int Age
        {
            get;
            set;
        }
    }





    // class Program:BaseTest
    class Program

    {
        //創建一個新的 Student 對象
        // Student s = new Student();

        //設置 student 的 code、name 和

        //public void output() {
        //    Console.WriteLine("www.walsin.com");
        //}
        //}

        //public void Output(string message) {
        //    Console.WriteLine(message);
        //}

        //public string Output(string message) {
        //    string str = "好好學習" + message;
        //    return str;

        //}

        //static string Output(string message) {
        //    string str = "好好學習+" + message;
        //    return str;
        //}

        /* class Rectangle {

            /* private double width, length;

             public void AcceptDetails() {
                 Console.WriteLine("請輸入長方形的長度: ");
                 length = Convert.ToDouble(Console.ReadLine());
                 Console.WriteLine("請輸入長方形的寬度: ");
                 width = Convert.ToDouble(Console.ReadLine());

             }

             private double GetArea() {
                 return width * length;
             }

             public void Display() {
                 Console.WriteLine("長方形的長度: {0}", length);
                 Console.WriteLine("長方形的寬度: {0}", width);
                 Console.WriteLine("長方形的面積: {0}", GetArea());

             }


             public double width, length;

             private double GetArea()
             {
                 return width * length;
             }

             public void Diplay()
             {
                 Console.WriteLine("長方形的長:{0}", length);
                 Console.WriteLine("長方形的寬{0}", width);
                 Console.WriteLine("長方形的面積{0}", GetArea());
             }
         }*/

        //public void Fuc(ref int val) {
        //    val *= val;
        //    Console.WriteLine("函數內部的值為:{0}", val);
        //}

        //public void getValue(out int x) {
        //    int temp = 11;
        //    x = temp;
        //    x *= x;

        //}

        //foreach
        public string getsum(params int[] arr)
        {
            int sum = 0;
            string str = "";
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                str += "+" + arr[i] + " ";

            }

            //foreach(int i in arr){
            //    sum += i;
            //    str += "+" + i + " ";
            //}
            str = str.Trim('+');
            str += "=" + Convert.ToString(sum);
            return str;


        }



        enum arr
        {
            winter,
            spring = 2,
            summer,
            autumn = 5,
            hot = 10,
            code = 15
        };

        /*public class Student
        {
            public int id;
            public string name;
            public string sex;
            public int age;
            public void insert(int i, string n, string s, int a)
            {
                id = i;
                name = n;
                sex = s;
                age = a;
            }
            public void display()
            {
                Console.WriteLine("編號: {0} 姓名: {1} 性別: {2} 年齡: {3}", id, name, sex, age);
            }

        }*/



        public class Person
        {
            private string name;
            private int age;
            public Person(string n, int a)
            {
                name = n;
                age = a;

            }
            public void display()
            {
                Console.WriteLine(" 姓名: {0} 性別: {1}", name, age);

            }


        }

        // public static int num = 0;

        //Program()
        //{
        //    num = 1;
        //}

        //static Program()
        //{
        //    num = 2;
        //}


        public class Student2
        {
            private Student2()
            {

            }


            public static int id;
            public static string name;
            public static void Display()
            {
                Console.WriteLine("姓名:" + name + " 編號:" + id);
            }
        }

        public class Student3
        {
            public Student3()
            {
                Console.WriteLine("類中的構造函數");
            }
            ~Student3()
            {
                Console.WriteLine("類中的析構函數");

            }

        }

        public class Webside
        {

            private string name;
            private string url;
            public Webside(string n, string u)
            {
                this.name = n;
                this.url = u;
            }
            public void Display()
            {
                Console.WriteLine(name + " " + url);
            }
        }

        //public class Test
        //{
        //    public Test()
        //    {
        //        Console.WriteLine("無參構造函數");
        //    }
        //    public Test(string text) : this()
        //    {
        //        Console.WriteLine(text);
        //    }
        //}

        public class Test02
        {
            int Temp0;
            int Temp1;
            public int this[int index]
            {
                get
                {
                    return (0 == index) ? Temp0 : Temp1;

                }




                set
                {
                    if (0 == index)
                        Temp0 = value;
                    else
                        Temp1 = value;

                }

            }
        }

        public class Test
        {
            public static string str;
            public void setStr(string s) {
                str = s;
            }
            public void getStr() {
                Console.WriteLine(str);
            }
        }

        void print(int i) {
            Console.WriteLine("打印 int 類型的數據:{0}", i);
        }
        void print(double d) {
            Console.WriteLine("打印double 類型的數據: {0}", d);
        }

        void print(string s) {
            Console.WriteLine("打印sting 類型的數據:{0}", s);
        }

        int c;

        public void MethodToImplement()
        {
            Console.WriteLine("實現 IMyInterface 介面中的 MethodToImplement 函數");
        }
        public void ParentInterfaceMethod()
        {
            Console.WriteLine("實現 IParentInterface 介面中的 ParentInterfaceMethod 函數");
        }

        /*private static void showMatch(string text, string expr) {
            Console.WriteLine("正式表達式未:" + expr);
            Console.WriteLine("匹配以“C”開頭的字符串:");
            MatchCollection mc = Regex.Matches(text, expr);
            foreach (Match m in mc) {
                Console.WriteLine(m);
            }
        }*/

        /*private static void showMatch(string text, string expr) {
            Console.WriteLine("正責表達式為:" + expr);
            Console.WriteLine("匹配以“m”開頭，以“e”結尾的單詞:");
            MatchCollection mc = Regex.Matches(text, expr);
            foreach (Match c in mc) {
                Console.WriteLine(c);
            }
        }*/
        [Conditional("Debug")]
        static void function1()
        {
            Myclass.Message("Function1 函數");
            function2();
        }

        [Conditional("Debug")]
        static void function2()
        {
            Myclass.Message("Function2 函數");
        }

        [Conditional("Debug")]
        static void Print0()
        {
            Console.WriteLine("Debug is defined");
        }

        [Conditional("Debug")]
        static void Print1()
        {
            Console.WriteLine("Debug is defined");
        }

        //public class Myclass
        //{
        //    [Conditional("DEBUG")]
        //    public static void Message(string msg)
        //    {
        //        Console.WriteLine(msg);
        //    }
        //}

        //[Conditional("DEBUG")]
        //static void Print3()
        //{
        //    Console.WriteLine("test");
        //}
        [Obsolete("OldMethod 已弃用，请改用 NewMethod", true)]
        static void Method() {
            Console.WriteLine("已棄用的函數");
        }

        static void newMethod() {
            Console.WriteLine("新定義的函數");
        }

        [DeBugInfo(40, "Huhu", "02/22/2023", Message = "类型匹配")]
        [DeBugInfo(45, "Huhu", "02/23/2023", Message = "返回值类型不匹配")]
        [DeBugInfo(46, "Huhu", "02/24/2023", Message = "未使用变量")]
        class Rectangle {
            //成員變量
            protected double length;
            protected double width;
            public Rectangle(double l, double w) {
                length = l;
                width = w;
            }

            [DeBugInfo(55, "Huhu", "02/22/2023", Message = "返回的值類型不匹配")]
            public void Display()
            {
                Console.WriteLine("Length:{0}", length);
                Console.WriteLine("Width:{0}", width);
                Console.WriteLine("Area:{0}", GetArea());
            }

            [DeBugInfo(56, "Huhu", "02/22/2023", Message = "返回值类型不匹配")]
            public double GetArea()
            {
                return length * width;
            }


        }

        //一個自定義特性 BugFix 被賦給類及其成員
        [AttributeUsage(AttributeTargets.Class |
            AttributeTargets.Constructor |
            AttributeTargets.Field |
            AttributeTargets.Method |
            AttributeTargets.Property,
            AllowMultiple = true)]
        public class DeBugInfo : System.Attribute {
            private int bugNo;
            private string developer;
            private string lastReview;
            public string message;

            public DeBugInfo(int bg, string dev, string d) {
                this.bugNo = bg;
                this.developer = dev;
                this.lastReview = d;
            }

            public int BugNo {
                get {
                    return bugNo;
                }
            }

            public string Developer
            {
                get
                {
                    return developer;
                }
            }

            public string LastReview
            {
                get
                {
                    return lastReview;
                }
            }

            public string Message
            {
                get
                {
                    return message;
                }
                set
                {
                    message = value;
                }
            }

        }

        //聲明sting 類型的Code 屬性
        public string Code {
            get {
                return Code;
            }

            set {
                Code = value;
            }
        }

        //聲明 string 類型的Name 屬性
        public string Name {
            get {
                return Name;
            }
            set {
                Name = value;
            }
        }

        //聲明 int 類型的 Age 屬性
        public int Age {
            get {
                return Age;
            }
            set {
                Age = value;
            }
        }



        //public string this[int index]
        //{
        //    get
        //    {
        //        string tmp;
        //        if (index >= 0 && index <= size - 1) {
        //            tmp = namelist[index];
        //        }
        //    }else{
        //        tmp = "";
        //    }
        //    return(tmp);
        //}

        //索引器
        /*static public int size = 10;
        private string[] namelist = new string[size];
        public Program() {
            for (int i = 0; i < size; i++) {
                namelist[i] = "NULL";
            }
        }  
        
        public string this[int index] {
            get {
                string tmp;
                if (index >= 0 && index <= size - 1) {
                    tmp = namelist[index];
                }
                else {
                    tmp = "";
                }
                return (tmp);
            }
            set {
                if (index >= 0 && index <= size - 1) {
                    namelist[index] = value;
                }
            }
        }

        public int this[string name] {
            get {
                int index = 0;
                while (index < size) {
                    if (namelist[index] == name) {
                        return index;                        
                    }
                    index++;
                }
                return index;
            }
        }*/

        //委託
        /*static int num = 10;

        public static int AddNum(int p) {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum() {
            return num;
        }*/

        static FileStream fs;
        static StreamWriter sw;
        //委託聲明
        public delegate void printString(string s);

        //該方法打印到控制台
        public static void WriteToScreen(string str) {
            Console.WriteLine("The String is :{0}", str);
        }

        //該方法打印到文件
        public static void WriteToFile(string s) {
            fs = new FileStream("./message.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        //該方法把委託作為參數，並使用它調用方法
        public static void sendString(printString ps) {
            ps("中文網");
        }

        /****************發佈器類******************/
        public class PublisherDemo {
            private string value;

            public delegate void MyEntrust(string str);

            public event MyEntrust MyEvent;

            public void SetValue(string s) {
                value = s;
                MyEvent(value);         //觸發事件
            }
        }

        /******************訂閱器類*******************/
        public class SubscriberDemo
        {
            public void printf(string str)
            {
                Console.WriteLine(str);
            }
        }

        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        // static int i = 0;

        //static Program() {
        //    i = 3;
        //    Console.Write("實例被調用:");
        //}


        /*delegate T NumberChanger<T>(T n);
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q) {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }*/

        delegate void NumberChanger(int n);
        static int num = 10;
        public static void AddNum(int p)
        {
            num += p;
            Console.WriteLine("命名函數: {0}", num);
        }

        public static void MultNum(int q)
        {
            num *= q;
            Console.WriteLine("命名函數: {0}", num);
        }

        public unsafe void swap(int*p, int *q) {
            int temp = *p;
            *p = *q;
            *q = temp;
        }

        /*public static void CallToChildThread() {
            Console.WriteLine("執行子線程");
            //線程暫停5000 毫秒
            int sleepfor = 5000;
            Console.WriteLine("子線程暫停 {0}秒", sleepfor /1000);
            Thread.Sleep(sleepfor);
            Console.WriteLine("繼續執行子線程");       
        }*/
        public static void CallToChildThread() {
            try {
                Console.WriteLine("執行子線程");
                //計數到 10
                for (int counter = 0; counter <= 10; counter++) {
                    Thread.Sleep(500);
                    Console.WriteLine(counter);
                }
                Console.WriteLine("子線程執行完成");
            } catch (ThreadAbortException e){
                Console.WriteLine("線程終止: {0}", e);
            } finally {
                Console.WriteLine("無法捕獲線程異常");
            }

        }







         static unsafe void Main(string[] args)
         {
            //銷毀線程
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("在 Main 函數中創建子線程");
            Thread childThread = new Thread(childref);
            childThread.Start();
            //停止主線程 一段時間
            Thread.Sleep(2000);
            //現在終止子線程
            Console.WriteLine("在 Main 函數中終止子線程");
            childThread.Abort();

            




            //管理線程
            //ThreadStart childref = new ThreadStart(CallToChildThread);
            //Console.WriteLine("在Main 函數中創建子線程");
            //Thread childThread = new Thread(childref);
            //childThread.Start();


   
            




            
            //創建線程
            //ThreadStart childref = new ThreadStart(CallToChildThread);
            //Console.WriteLine("在 Main 函數中創建子線程");
            //Thread childThread = new Thread(childref);
            //childThread.Start();




            //Thread th = Thread.CurrentThread;
            //th.Name = "主線程";
            //Console.WriteLine("這是{0}", th.Name);





            //使用指針訪問數組元素
            //int[] list = {5, 18, 27, 32};
            //fixed(int *ptr = list)
            
            ///* 顯示指針中數組地址*/
            //for (int i = 0; i <4; i++)
            //{
            //     Console.WriteLine("list[{0}]的內存地址為:{1}",i,(int)(ptr + i));
            //     Console.WriteLine("list[{0}]的值為: {1}", i, *(ptr + i));

            //}






            //蔣指針作為參數傳遞給函數
            //Program p = new Program();
            //int var1 = 10;
            //int var2 = 20;
            //int* x = &var1;
            //int* y = &var2;
            //Console.WriteLine("調用 Swap 函數前:var1 :{0}, var2 :{1}", var1, var2);
            //p.swap(x,y);
            //Console.WriteLine("調用 Swap 函數後:var1 :{0}, var2 :{1}", var1, var2);



            //使用指針檢索數據的值
            //int var = 21;
            //int* p = &var;
            //Console.WriteLine("變量 var 的值為: {0}", var);
            //Console.WriteLine("指針 P 指向的值為: {0}", p->ToString());
            //Console.WriteLine("指針P 的值為: {0}", (int)p);




            //double f = 3.1415;
            //double* p = &f;
            //Console.WriteLine("數據的內容是: {0}", f);
            //Console.WriteLine("數據在內存中的地址是: {0}", (int)p);




            //使用匿名函數創建委託實例
            /*NumberChanger nc = delegate (int x)
            {
                Console.WriteLine("匿名函數: {0}", x);
            };

            //使用匿名函數調用委託
            nc(10);

            //使用命名函數實例化委託
            nc = new NumberChanger(AddNum);

            //使用命名函數調用委託
            nc(5);

            //使用另一個命名函數實例化委託
            nc = new NumberChanger(MultNum);

            //使用命名函數調用委託
            nc(2);*/




            //創建委託實例
            //NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
            //NumberChanger<int> nc2 = new NumberChanger<int>(MultNum);

            ////使用委託對象調用方法
            //nc1(25);
            //Console.WriteLine("Num 的值為: {0}", getNum());
            //nc2(5);
            //Console.WriteLine("Num 的值為: {0}", getNum());



            // Console.Write(Program.i);


            //泛型方法
            /*int a, b;
            char c, d;
            a = 10;
            b = 20;
            c = 'I';
            d = 'V';

            //在交換之前顯示值
            Console.WriteLine("調用 swap 之前的 Int 值：");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("調用 swap 之前的字符值：");
            Console.WriteLine("c = {0}, d = {1}", c, d);

            //調用 swap
            Swap<int>(ref a, ref b);
            Swap<char>(ref c, ref d);

            //在交換之後顯示值
            Console.WriteLine("調用 swap 之後的 Int 值：");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("c = {0}, b = {1}", c, d);*/






            /*GeneriClass<string> str_gen = new GeneriClass<string>("中文網");
            GeneriClass<int> int_gen = new GeneriClass<int>(21312);
            GeneriClass<char> char_gen = new GeneriClass<char>('C');
            GeneriClass<double> double_gen = new GeneriClass<double>(3.24);*/

















            //點陣列
            //創建兩個大小為 8  的點陣列
            /*BitArray ba1 = new BitArray(8);
            BitArray ba2 = new BitArray(8);
            byte[] a = { 60 };
            byte[] b = { 13 };

            //把值 60 和13 存儲到點陣列中
            ba1 = new BitArray(a);
            ba2 = new BitArray(b);

            //ba1 的內容
            Console.WriteLine("點陣列 ba1 : 60");
            for (int i = 0; i < ba1.Count; i++) {
                Console.Write("{0} ", ba1[i]);
            }
            Console.WriteLine();

            //ba2 的內容
            Console.WriteLine("點陣列 ba2: 13");
            for (int i = 0; i < ba2.Count; i ++) {
                Console.Write("{0, -6}", ba2[i]);
            }
            Console.WriteLine();


            BitArray ba3 = new BitArray(8);
            ba3 = ba1.And(ba2);

            //ba3 的內容
            Console.WriteLine("執行按位於操作後的點陣 ba3:");
            for (int i =0; i < ba3.Count; i++) {
                Console.Write("{0, -6}", ba3[i]);
            }
            Console.WriteLine();

            ba3 = ba1.Or(ba2);
            Console.WriteLine("執行按位或操作後的點陣 ba3:");
            for (int i =0; i < ba3.Count; i ++) {
                Console.Write("{0, -6}", ba3[i]);
            }
            Console.WriteLine();*/

















            //隊列
            /*Queue q = new Queue();
            q.Enqueue('A');
            q.Enqueue('B');
            q.Enqueue('C');
            q.Enqueue('D');

            Console.WriteLine("當前隊列: ");
            foreach (char c in q) {
                Console.Write(c + " ");
            }
            Console.WriteLine("\r\n向隊列中添加一些元素: \r\nE F");
            q.Enqueue('E');
            q.Enqueue('F');
            Console.WriteLine("當前隊列: ");
            foreach (char c in q) {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            Console.WriteLine("刪除一些值: ");
            char ch = (char)q.Dequeue();
            Console.Write(ch + "\r\n");
            Console.WriteLine("當前隊列: ");
            foreach (char c in q) {
                Console.Write(c + " ");
            }*/






            //堆栈
            /*Stack st = new Stack();

            st.Push('A');
            st.Push('B');
            st.Push('C');
            st.Push('D');

            Console.WriteLine("當前堆棧中的元素:");
            foreach (char c in st) {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            st.Push('E');
            st.Push('F');
            Console.WriteLine("堆棧中下一個可彈出的值:\r\n{0}", st.Peek());
            Console.WriteLine("當前堆棧中的元素: ");
            foreach (char c in st) {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            Console.WriteLine("刪除值下面的值: ");
            Console.Write(st.Pop() + " ");
            Console.Write(st.Pop() + " ");
            Console.Write(st.Pop() + " " + "\r\n");

            Console.WriteLine("當前堆棧中的元素: ");
            foreach (char c in st) {
                Console.Write(c + " ");
            }*/
















            //排序列表
            /*SortedList s1 = new SortedList();

            s1.Add("001", "小明");
            s1.Add("002", "小紅");
            s1.Add("003", "小強");
            if (s1.ContainsValue("張三"))
            {
                Console.WriteLine("該學生姓名以存在");
            }
            else {
                s1.Add("004", "張三");
            }

            //獲取鍵的集合
            ICollection key = s1.Keys;

            foreach (string k in key) {
                Console.WriteLine(k + ": " + s1[k]);
            }*/






            /*Hashtable ht = new Hashtable();

            ht.Add("001", "小明");
            ht.Add("002", "小紅");
            ht.Add("003", "小強");

            if (ht.ContainsKey("004"))
            {
                Console.WriteLine(ht["002"] + ":該學生姓名以存在");
            }
            else {
                ht.Add("004", "張三");
            }

            //獲取鍵的集合
            ICollection key = ht.Keys;

            foreach (string k in key) {
                Console.WriteLine(k + ":" + ht[k]);
            }*/



            /*ArrayList arr_list = new ArrayList();
            Console.WriteLine("以 Num1, Num2, Num3,....Num 的形式輸入一個字符串:");
            string str = Console.ReadLine();
            string[] strArray = str.Split(',');
            foreach (string s in strArray) {
                arr_list.Add(s);
            }

            Console.WriteLine("Capacity: {0}", arr_list.Capacity);
            Console.WriteLine("Count:{0}", arr_list.Count);

            Console.Write("Content:");
            foreach (string i in arr_list) {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Sorted Content:");
            arr_list.Sort();
            foreach (string i in arr_list) {
                Console.Write(i + " ");
            }
            Console.WriteLine();*/







            // PublisherDemo e = new PublisherDemo();      /*實例發佈器類*/
            // SubscriberDemo v = new SubscriberDemo();    /*實例訂閱器類*/
            // e.MyEvent += new PublisherDemo.MyEntrust(v.printf);
            // e.SetValue("中文網");







            //printString ps1 = new printString(WriteToScreen);
            //printString ps2 = new printString(WriteToFile);
            //sendString(ps1);
            //sendString(ps2);


            //創建委託實例
            /* NumberChanger nc;
             NumberChanger nc1 = new NumberChanger(AddNum);
             NumberChanger nc2 = new NumberChanger(MultNum);

             nc = nc1;
             nc += nc2;

             //調用多播
             nc(5);
             Console.WriteLine("num 的值為: {0}", getNum());*/


            //創建委託實例
            /*NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            //使用委託對象調用方法
            nc1(25);
            Console.WriteLine("num 的值為: {0}", getNum());
            nc2(5);
           // Console.WriteLine("num 的值為: {0}", getNum());
            Console.WriteLine("num 的值為: {0}", num);*/







            /*Program names = new Program();
            names[0] = "C語言中文網";
            names[1] = "http://c.biancheng.net/";
            names[2] = "c#教程";
            names[3] = "索引器";
            for (int i = 0; i < size; i++) {
                Console.WriteLine(names[i]);
            }

            //使用帶有 string 參數的第二個索引器
            Console.WriteLine("c#教程 的索引為: {0}", names["索引器"]);*/

            //創建一個新的 Student 對象
            /*Student s = new Student();


            //設置 Student 的 code、 name 和 age
            s.Code = "001";
            s.Name = "Huhu";
            s.Age = 11;
            s.Love = "貓";
        
            Console.WriteLine("學生信息: {0}", s);

            //增加年齡
            //s.Age = s.Age++;
             s.Age = ++s.Age ;
            //s.Age = s.Age + 2;
            Console.WriteLine("學生信息: {0}", s);*/








            /*Rectangle rec = new Rectangle(5, 8);
            rec.Display();
            Type type = typeof(Rectangle);

            //遍厲 Rectangle 類的屬性
            foreach (Object attributes in type.GetCustomAttributes(false)) {
                DeBugInfo dbi = (DeBugInfo)attributes;

                if (null != dbi) {
                    Console.WriteLine("Bug編號:{0}", dbi.BugNo);
                    Console.WriteLine("開發者:{0}", dbi.Developer);
                    Console.WriteLine("上次審核時間:{0}", dbi.LastReview);
                    Console.WriteLine("評論:{0}", dbi.Message);
                }
            }

            //遍厲 函數屬性
            foreach (MethodInfo m in type.GetMethods()) {
                foreach (Attribute a in m.GetCustomAttributes(true)) {
                    DeBugInfo dbi = (DeBugInfo)a;
                    if (null != dbi) {
                        Console.WriteLine("Bug 編號:{0}, 函數名:{1}", dbi.BugNo, m.Name);
                        Console.WriteLine("開發者:{0}", dbi.Developer);
                        Console.WriteLine("上次審核時間:{0}", dbi.LastReview);
                        Console.WriteLine("評論:{0}", dbi.Message);
                    }
                }
            }*/



            //newMethod();
            //Print1();
            // Print0();
            // Myclass.Message("Main 函數");

            // function1();





            ////創建一個 DirectoryInfo 對象
            //DirectoryInfo mydir = new DirectoryInfo(@"C:\");

            ////獲取目錄中的文件以及它們的名稱和大小
            //FileInfo[] f = mydir.GetFiles();
            //foreach (FileInfo file in f) {
            //    Console.WriteLine("文件名稱: {0} 最後寫入時間: {1}", file.Name, file.LastWriteTime);
            //}




            /*BinaryWriter bw;
            BinaryReader br;
            int i = 25;
            double d = 3.1415;
            bool b = true;
            string s = "C語言中文網";
            //創建文件
            try {
                bw = new BinaryWriter(new FileStream(@"C:\mydata", FileMode.CreateNew));
            } catch (IOException h) {
                Console.WriteLine(h.Message + "\n 文件創建失敗");
                File.Delete(@"C:\mydata");
                
                return;
            }

            //寫入文件
            try {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            } catch (IOException h) {
                Console.WriteLine(h.Message + "\n 文件寫入失敗！");
            }
            bw.Close();

            //讀取文件
            try {
                br = new BinaryReader(new FileStream(@"C:\mydata", FileMode.Open));
            } catch (IOException h) {
                Console.WriteLine(h.Message + "\n 文件打開失敗！");
                return;
            }

            try {
                i = br.ReadInt32();
                Console.WriteLine("integer data:{0}", i);
                d = br.ReadDouble();
                Console.WriteLine("integer data:{0}", d);
                b = br.ReadBoolean();
                Console.WriteLine("integer data:{0}", b);
                s = br.ReadString();
                Console.WriteLine("integer data:{0}", s);

            } catch (IOException h) {
                Console.WriteLine(h.Message + "\n 文件讀取失敗！");
            }
            br.Close();*/




            //string[] str = new string[] {
            //    "C語言中文網",
            //"http://c.biancheng.net/",
            //"C#教程"};

            //StreamWriter file = new StreamWriter(@"C:\demo.txt");
            //foreach (string s in str)
            //{
            //    file.Write(s + " ");
            //}
            //file.Close();

            //string line = "";
            //StreamReader readfile = new StreamReader(@"C:\demo.txt");
            //while ((line = readfile.ReadLine()) != null)
            //{
            //    Console.WriteLine(line);
            //}
            //readfile.Close();
            //Console.Clear();



            //try {
            //    StreamReader file_02 = new StreamReader(@"C:\demo1.txt");
            //    string Line;
            //    while ((Line = file_02.ReadLine()) != null) {
            //        Console.WriteLine(Line);
            //    }
            //} catch (Exception h) {
            //    Console.WriteLine("無法讀取文件");
            //    Console.WriteLine(h.Message);
            //}

            Console.ReadLine();






            //FileStream file = new FileStream(@"C:\test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //for (int i = 0; i < 20; i++)
            //{
            //    file.WriteByte((byte)i);
            //}

            //file.Position = 0;

            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(file.ReadByte() + " ");
            //}
            //file.Close();


            //TestUserDefinedException test = new TestUserDefinedException();
            //try
            //{
            //    test.validata(5);
            //}
            //catch (InvalidAgeException r) {
            //    Console.WriteLine("invalidAgeException: {0}", r);
            //}
            //Console.WriteLine("其它代碼");

            //try {
            //    int a = 123;
            //    int b = 0;
            //    int x = a / b;
            //} catch (Exception e) {
            //    Console.WriteLine("捕獲到的異常:{0}", e);
            //} finally {
            //    Console.WriteLine("finally 語句塊的代碼");
            //}

            //Console.WriteLine("程序中的其它代碼");

            //string str = "C    語言   中文網      ";
            //string pattern = "\\s+";
            //Regex rgx = new Regex(pattern);
            //string result = rgx.Replace(str, "");

            //Console.WriteLine("原始字符串: {0}", str);
            //Console.WriteLine("替換後的字符串: {0}", result);



            //string str = "make mazm and managi to measure it";
            //showMatch(str, @"\bm\S*e\b");

            //string str = "C#教程 C語言中文網 c.biancheng.net正責表達式 c.text01 c.test02";
            //showMatch(str, @"\bc\S*");


            //#if (PI)
            //System.Console.WriteLine("PI 已定義");
            //#else
            //Console.WriteLine("PI 未定義");
            //#endif






            //firstClass first = new firstClass();
            //scendClass scend = new scendClass();
            //first.sayGoodmoning();
            //scend.sayHello();



            //Program p = new Program();
            //p.MethodToImplement();
            //p.ParentInterfaceMethod();




            //Website web = new Website();
            //web.setValue("C語言中文網", "HTTP://c.biancheng.net");
            //web.disPlay();





            //Box box1 = new Box();
            //Box box2 = new Box();
            //Box box3 = new Box();
            //double volume = 0.0;

            //box1.setLength(6.0);
            //box1.setBreadth(7.0);
            //box1.setHeight(5.0);

            //box2.setLength(12.0);
            //box2.setBreadth(13.0);
            //box2.setHeight(10.0);

            //volume = box1.getVolume();
            //Console.WriteLine("Box1 的體積:{0}", volume);

            //volume = box2.getVolume();
            //Console.WriteLine("Box2 的體積:{0}", volume);

            //box3 = box1 + box2;

            //volume = box3.getVolume();
            //Console.WriteLine("box3 的體積:{0}", volume);
            //Console.ReadKey();
















            //Rectangle r = new Rectangle(10,20);
            //double a = r.area();
            //Console.WriteLine("長方形的面積為: {0}", a);



            //Program p = new Program();

            //p.print("C語言中文網");
            //p.print(3.1415926);
            //p.print(123);







            //Rectangle oblong = new Rectangle();
            //oblong.setWidth(3);
            //oblong.setHeight(4);
            //int area = oblong.getArea();
            //int girth = oblong.getGirth();
            //Console.WriteLine("長方形的面積為: {0}", area);
            //Console.WriteLine("長方形的面積為: {0}", girth);




            //Program childTest = new Program();
            //childTest.c = childTest.a * childTest.b;
            //Console.WriteLine(childTest.c);












            //Test.str = "C语言中文网";
            //Console.WriteLine(Test.str);
            //Test test1 = new Test();
            //test1.getStr();

            //Test test2 = new Test();
            //test2.getStr();
            //test2.setStr("http://c.biancheng.net/");
            //test1.getStr();
            //test2.getStr();







            //Test02 a = new Test02();
            //Console.WriteLine("Temp0:{0}, Temp1:{1}", a[0], a[1]);
            //a[0] = 15;
            //a[1] = 20;
            //Console.WriteLine("Temp0:{0}, Temp1:{1}", a[0], a[1]);




            //Test test = new Test("C語言中文網");
            //Webside site = new Webside("C語言中文網", "http://c.biancheng.net/");
            //site.Display();
            //Console.ReadLine();








            //Student3 stu1 = new Student3();
            //Student3 stu2 = new Student3();
            // Console.ReadKey();
            // Student2 st = new Student2();





            /*Student2.id = 101;
            Student2.name = "張三";
            Student2.Display();
            Console.ReadLine();*/









            //Console.WriteLine("num = {0}", num);
            //Program Obj = new Program();
            //Console.WriteLine("num = {0}", num);
            //Console.ReadLine();
            //Console.WriteLine("num = {0}", num);
            //Program Obj = new Program();
            //Console.WriteLine("num = {0}", num);
            //Console.ReadLine();








            //Person C = new Person("李四", 18);
            //C.display();
            //Console.ReadLine();









            //Student stu1 = new Student();
            //Student stu2 = new Student();
            //stu1.insert(10, "張三", "男", 18);
            //stu1.display();
            //stu2.insert(11, "李四", "女", 16);
            //stu2.display();






            //foreach (arr i in arr.GetValues(typeof(arr)))
            //{
            //   Console.WriteLine("{0} = {1}", i, (int)i);
            //   //Console.WriteLine(i);
            //}
            //Console.ReadLine();








            //books book1 = new books();
            //books book2 = new books();
            //book1.getValue("c#教程", "c語言中文網", "c#編程教程",12345);
            //book2.getValue("HTTP教程", "c語言中文網", "HTTP協議教程", 122312);
            //book1.disPlay();
            //book2.disPlay();
            //Console.ReadLine();





            //books book1;
            //books book2;
            ////定義book1 的屬性
            //book1.title = "c#教程";
            //book1.author = "c語言中文網";
            //book1.subject = "c#編程教程";
            //book1.book_id = 123456;
            ////定義book2 的屬性
            //book2.title = "HTTP教程";
            //book2.author = "c語言中文網";
            //book2.subject = "http協議教程";
            //book2.book_id = 7879;
            ////輸出 book1 的屬性信息
            //Console.WriteLine("book1 title: {0}", book1.title);
            //Console.WriteLine("book1 author: {0}",book1.author);
            //Console.WriteLine("book1 subject: {0}",book1.subject);
            //Console.WriteLine("book1 book_id: {0}",book1.book_id);
            ////輸出 book2 的屬性信息
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("book2 title: {0}", book2.title);
            //Console.WriteLine("book2 author: {0}", book2.author);
            //Console.WriteLine("book2 subject: {0}", book2.subject);
            //Console.WriteLine("book2 book_id: {0}", book2.book_id);
            //Console.ReadLine();




            //string[] arr = new string[]{
            //"C語言中文網:",
            //" ",
            //"http://c.biancheng.net/",
            //" ",
            //"c# 教程"
            //};

            //string arr1 = string.Join(" ", arr);
            //Console.WriteLine(arr1);
            //Console.ReadLine();





            //string arr = "http://c.biancheng.net/";
            //Console.WriteLine("原字符串:" + arr);
            //string substr = arr.Substring(7);
            //Console.WriteLine("截取之後的字符串:" + substr);
            //Console.ReadLine();















            //string str1 = "http://c.biancheng.net";
            //string str2 = "biancheng";
            //Console.WriteLine(str1.Contains(str2));
            //if (str1.Contains(str2))
            //{
            //    Console.WriteLine(str1 + "中包含 " + str2);
            //}
            //else {
            //    Console.WriteLine(str1 + "中不包含 " + str2);
            //}
            //Console.ReadLine();






            //string str1 = "http://c.biancheng.net";
            //string str2 = "c.biancheng.net";
            //Console.WriteLine(string.Compare(str1, str2));
            //if (string.Compare(str1, str2) == 0)
            //{
            //    Console.WriteLine(str1 + "與" + str2 + " 相同");
            //}
            //else {

            //    Console.WriteLine(str1 + " 與" + str2 + " 不同");
            //}
            //Console.ReadLine();








            //string name = "C語言中文网";
            //string str = "歡迎訪問:" + name + " !";
            //string str2 = System.String.Empty;
            // Console.WriteLine("str2 的值為" + str2);
            // System.String url = "http://c.biancheng.net";

            // var temp = "c#教程";
            // Console.WriteLine("temp 的值為: " +  temp);
            // Console.ReadLine();

            //定義一個常量字符串
            // const string str3 = "這是個常量字符串!";
            // Console.WriteLine("str3 的值為: " + str3);
            // Console.ReadLine();

            //使用字符串構造函數定義字符串
            //char[] arr = new char[]{'H', 'e', 'l', 'l', 'o', '!' };
            //string message = new string(arr);
            //string message = "Hello";
            //Console.WriteLine("message 的值為:" + message);
            //Console.ReadLine();

















            //int[] arr = new int[] {15, 33, 29, 55, 10, 11 };
            //int[] arr2 = new int[6];
            //int[] arr = new int[6];
            //Console.WriteLine(arr[5]);
            //Console.WriteLine("數組 arr 的長度為: "+ arr.Length);

            //Array.Sort(arr);
            //string str = " ";
            //foreach (int i in arr) {
            //    str += i + ", ";
            //};
            //str = str.Trim(' ');
            //str = str.Trim(',');
            //Console.WriteLine("排序後的數組arr 為:{0} ",str);
            //Console.ReadLine();

            //Console.WriteLine("\n數組arr 中的值為6的元素的索引為:"+ Array.IndexOf(arr,11));

            //Array.Copy(arr, arr2, arr.Length);
            //Array.Sort(arr2);
            //string str = "";
            //foreach (int i in arr2) {               
            //    str += i + ", ";
            //}

            //str = str.Trim(' ');
            //str = str.Trim(',');
            //Console.Write("打印機數組 arr2:{0}",str);
            //Console.ReadLine();









            //int[] arr = new int[] {15, 22, 32, 29, 51, 10, 12 };
            //string str = " ";
            //foreach (int i in arr) {
            //str += i + ", ";
            //}
            //Console.WriteLine(str);
            //Console.ReadLine();






            //Program Obj = new Program();
            //string str = Obj.getsum(1, 2, 3, 4, 5, 6);
            //Console.WriteLine(str);
            //int[] arr = {2, 4, 6, 8, 10};
            //string str2 = Obj.getsum(arr);
            //Console.WriteLine(str2);
            //Console.ReadLine();







            //string[] names = {"小明","小紅","小強"};
            //string[] course ={"語文","數學","英語"};
            //int[][] arr = {
            //              new int[]{98, 85, 90},
            //              new int[]{91, 95, 93},
            //              new int[]{88, 89, 97},
            //              };

            //for (int i = 0; i < names.Length;i++ ) {
            //    string str = " ";
            //    for (int j = 0; j < arr[i].Length; j++) {
            //        str += course[j] + " " + arr[i][j] + ", ";                           
            //    }
            //    Console.WriteLine("{0}的成績為:{1}",names[i], str);
            //};
            //Console.ReadLine();






            //int[][] arr = new int[][]{
            //new int[]{31, 22, 16, 99},
            //new int[]{21, 54, 6, 77, 98, 51},
            //new int[]{112, 25}
            //};

            //for (int i = 0; i < arr.Length;i++ ) {
            //    for (int j = 0; j < arr[i].Length;j++ ) {
            //        Console.Write(arr[i][j] + " ");

            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();





            //int[][,] arr = new int[][,] {
            //    new int[,]{
            //        {1, 1},
            //        {2, 3}              
            //    },
            //    new int[,]{
            //        {5, 8},
            //        {13, 21},
            //        {34, 55}
            //    },
            //    new int[,]{
            //        {89, 144},
            //        {233, 377},
            //        {610, 987}             
            //    }
            //};
            //int a = arr[0][1, 1];



            //int[][] arr = new int[][]{
            //    new int[]{1, 2, 3, 4, 5},
            //    new int[]{6, 7, 8, 9},
            //    new int[]{10, 11}

            //};
            // int a = arr[2][0];
            //Console.WriteLine("arr[0][1, 1]的值為: {0}",a);
            //Console.ReadLine();






            //int[,] arr = new int[,]{
            //    {0, 1, 2, 3},{4, 5, 6, 7},{8, 9, 10, 11}
            //};

            //for (int i = 0; i < 3; i++ ) {
            //    for (int j = 0; j < 4;j++ ) {
            //        Console.WriteLine("arr[{0},{1}] = {2}", i, j, arr[i, j]);
            //        Console.ReadLine();                    
            //    }

            //};








            //int[,] arr = new int[,] {{0, 1, 2, 3},{4, 5, 6, 7},{8, 9, 10, 11}};
            //int a = arr[1, 0];
            //Console.WriteLine("第二行第一列的數組元素是:{0}",a);
            //Console.ReadLine();








            //int[] arr = new int[] { 100, 101, 102, 103, 104, 105, 106, 107, 108, 109 };
            //int index = 0;
            //foreach (int i in arr)
            //{
            //    Console.WriteLine("arr[{0}] = {1}", index, i);
            //    index++;

            //}
            //Console.ReadLine();








            //int[] arr = new int[10] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //for (int i = 0; i < 10;i++ ) {
            //    Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            //}
            //Console.ReadLine();






            //int? num1 = null;
            //int? num2 = 123;
            //int num3;

            //num3 = num1 ?? 321;
            //Console.WriteLine("num3  = {0}", num3);

            //num3 = num2 ?? 312;
            //Console.WriteLine("num3 = {0}", num3);
            //Console.ReadLine();









            //Int32  val = 33;
            //Program Obj = new Program();
            //Console.WriteLine("调用函数之前的值：{0}", val);
            //Obj.getValue(out val);
            //Console.WriteLine("调用函数之后的值:{0}", val);
            //Console.ReadLine();


















            //Rectangle Obj = new Rectangle();
            //Obj.length = 3;
            //Obj.width = 4;
            //Obj.Diplay();
            //Console.ReadLine();


            //Rectangle Obj = new Rectangle();
            //Obj.AcceptDetails();
            //Obj.Display();
            //Console.ReadLine();



            //string ms = Output("天天向上");
            //Console.WriteLine(ms);
            //Console.ReadLine();


            //string str = "Hello World!";
            //Program Obj = new Program();
            //Obj.Output(str);
            //Console.ReadLine();


            //Program obj = new Program();
            //obj.output();
            //Console.ReadLine();




            //    int count = 1;
            //login:
            //    Console.WriteLine("請輸入用戶");
            //    string username = Console.ReadLine();
            //    Console.WriteLine("請輸入密碼");
            //    string password = Console.ReadLine();
            //    if (username == "walsin" && password == "12345")
            //    {
            //        Console.WriteLine("登錄成功");
            //    }
            //    else {
            //        count++;
            //        if (count > 3)
            //        {
            //            Console.WriteLine("用戶密碼錯誤次數太多！退出！");
            //        }
            //        else {
            //            Console.WriteLine("用戶名或密碼錯誤");
            //            goto login;//返回login 標籤處重新輸入用戶名和密碼
            //        }
            //    }







            //for (int i = 1; i <= 9; i++)
            //{
            //    if (i == 5)
            //    {
            //        continue;

            //    }
            //    Console.Write("{0} ", i);
            //}
            //Console.ReadLine();











            //int[] arr = new int[100];
            //for (int i = 0; i < 100; i++) {
            //    arr[i] = i + 1;
            //}
            //int sum = 0;
            //foreach (int j in arr) {
            //    sum = sum + j;
            //}
            //Console.WriteLine("1~100以內數字的和為:{0}", sum);
            //Console.ReadLine();







            //int[] arr = new int[] { 1, 3, 5, 33, 45, 56 };
            //foreach (int i in arr) {
            //    Console.Write("{0} ", i);
            //}
            //Console.ReadLine();




            //int i = 1;
            //do{
            //    int j = 1;
            //    do {
            //        Console.Write("{0} x {1} = {2} ", j, i, j*i);                              
            //    j++;               
            //    }while(j <= i);               
            // i++;
            // Console.WriteLine();
            //}while(i <= 9);
            //Console.ReadLine();





            //int i = 1;
            //do
            //{
            //    Console.Write("{0} ", i);
            //    i++;
            //} while (i <= 9);
            //Console.ReadLine();



            //int i = 1;
            //while (i <= 9){
            //    int j = 1;
            //    while (j <= i) {
            //        Console.Write("{0} x {1} = {2} ", j, i, i*j);
            //        j++;
            //    }
            //    i++;
            //    Console.WriteLine();
            //}
            //Console.ReadLine();








            //int i = 1;
            //while (i <= 9){
            //    Console.WriteLine("{0}", i);
            //    i++;

            //}
            //Console.WriteLine(Convert.ToString(i));
            //Console.ReadLine();




            //for (; ; ) {
            //   // Console.WriteLine("編程幫！");        

            //}




            //for (int i = 1; i <= 9;i++ ) {
            //    for (int j = 1; j <= i; j++ ) {
            //        Console.WriteLine("{0} x {1} = {2}", j, i, i*j);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();









            //    for (int i = 1; i <= 9; i++ ) {
            //        Console.WriteLine("{0}", i);
            //    }
            //    Console.ReadKey();


            //Console.WriteLine("請輸入學生考試成績(0~100的整數)");
            //int points = Convert.ToInt32(Console.ReadLine());
            //switch (points / 10){
            //    case 10:
            //        Console.WriteLine("優秀");
            //        break;
            //    case 9:
            //        Console.WriteLine("優秀");
            //        break;
            //    case 8:
            //        Console.WriteLine("良好");
            //        break;
            //    case 7:
            //        Console.WriteLine("及格");
            //        break;
            //    case 6:
            //        Console.WriteLine("及格");
            //        break;
            //    default:
            //        Console.WriteLine("不及格");
            //        break;
            //}

            //Console.ReadKey();




            //    Console.WriteLine("請輸入學生的成績:");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num < 0 || num > 100) {
            //        Console.WriteLine("您輸入的成績有誤");
            //    }
            //    else if (num >= 0 && num < 60) {
            //        Console.WriteLine("不及格");
            //    }
            //    else if (num >= 60 && num < 70) {
            //        Console.WriteLine("及格");
            //    }else if (num >= 70 && num < 80 ){
            //        Console.WriteLine("中等");
            //    }
            //    else if (num >= 80 && num < 90) {
            //        Console.WriteLine("良好");
            //    }else if (num >= 90 && num <= 100){
            //        Console.WriteLine("優秀");
            //    }
            //    Console.ReadKey();


            //Console.WriteLine("請輸入一個數字");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num % 2 == 0){
            //    Console.WriteLine("{0}是偶數", num);
            //}else{
            //    Console.WriteLine("{0}是奇數", num);
            //}
            //Console.ReadKey();



            //int num = 12;
            //if(num % 2 == 0){
            //    Console.WriteLine("{0}是偶數", num);
            //    Console.ReadKey();

        }



        //    Console.WriteLine("c語言中文網\thttp://c.biancheng.net\n\n");
        //    Console.ReadKey();



        //const double pi = 3.14;   //定義一個常量

        //double r;
        //Console.WriteLine("本程式可以計算圓的面積，請輸入一個數字作為圓的半徑: ");
        //r = Convert.ToDouble(Console.ReadLine());

        //double c = pi * r * r;
        //Console.WriteLine("半徑為：{0},圓的面積為:{1}", r, c);
        //Console.ReadKey();




        /*int a, b ,c;
        a = 5;
        b = 4;
        c = a * b;

        Console.WriteLine("c = {0}, b = {1}, a = {2}", c, b, a);
       Console.ReadLine();*/

        /*int a, b;
        Console.WriteLine("請輸入第一個數字：");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("請輸入第二個數字：");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0}*{1}={2}", a, b, a * b);
        Console.ReadKey();*/

        /*double a = 332.25;
        int i;
        i = (int)a;
        Console.WriteLine("轉換前{0}，轉換後{1}",a,i);
        Console.ReadKey();*/


        /*int i = 23;
        float f = 53.005f;
        double d = 234.566d;
        bool b = true;
        char n = '2';
        string m = "23131232132";
        string p = "3";
        Console.WriteLine(i.ToString());
        Console.WriteLine(f.ToString());
        Console.WriteLine(d.ToString());
        Console.WriteLine(b.ToString());
        Console.WriteLine(n.ToString());
        Console.WriteLine(m.ToString());
        Console.WriteLine(p.ToString());
        Console.ReadKey();*/

        /*int a = 5;
        int b = 20;
        int c;

        c = a;
        Console.WriteLine("c = a 的值為 {0}", c);
        c += b;
        Console.WriteLine("c += a 的值為 {0}", c);
        c = b;
        c -= a;
        Console.WriteLine("c -= a 的值為 {0}", c);
        c *= b;
        Console.WriteLine("c *= b 的值為 {0}", c);
        c /= a;
        Console.WriteLine(" c /= a 的值為 {0}", c);

        Console.ReadKey();*/





        /* int c = ++a;
        int d =  a++ ;

         Console.WriteLine("a + b = {0}", a + b);
         Console.WriteLine("a - b = {0}",a - b);
         Console.WriteLine("a * b = {0}",a * b);
         Console.WriteLine("a / b = {0}",a / b);
         Console.WriteLine("a % b = {0}",a % b);
         Console.WriteLine( ++a);
         Console.WriteLine("c的值是{0}", c);
         Console.WriteLine("a++的值是{0}", a++);
         Console.WriteLine(d);
         Console.ReadKey();*/

        /*if (a == b)
        {
            Console.WriteLine("a 等於 b");
            Console.ReadKey();
        }
        else {
            Console.WriteLine("a 不等於 b");
            Console.ReadKey();
        }
        if (a < b)
        {
            Console.WriteLine("a 小於 b");
            Console.ReadKey();
        }
        else {
            Console.WriteLine("a 不小於b");
            Console.ReadKey();
        }*/

    }
}

namespace First {
    public class firstClass {
        public void sayGoodmoning() {
            Console.WriteLine("First 命名空間下demoClass 類中的Goodmoning函數");
        }
    }

    namespace Second
    {
        public class scendClass
        {
            public void sayHello()
            {
                Console.WriteLine("Scend 命名空間下demoClass類中的 sayHello函數");
            }
        }
    }


}

/*namespace Second {
    public class scendClass {
        public void sayHello() {
            Console.WriteLine("Scend 命名空間下demoClass類中的 sayHello函數");
        }
    }
}*/


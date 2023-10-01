namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Rectangle //создаём класс
        {
            private int a; // Это приватные поля, с ними нельзя работать вне класса
            private int b;

            public Rectangle(int a, int b) //это конструктор, по сути это функция, которая может выполнять 
                //что-то при создание объекта
            {
                
                this.a = a; //имена параметров конструкрта совпадают с именами полей, поэтому через this 
                //даём значении парметров нашим полям
                this.b = b;
            }

            public int perimetr() // это функция(метод), которая возвращает значение.
            {
                int P = this.a *2 + this.b *2;
                return P;
            }

            public int s_funn()
            {
                return this.a * this.b;
            }

            //Это свойство, которая позволяет работать с приватными полями вне класса
            public int Re_Line_A
            {

                get { return a; }//это мы вызываем значение поля
                set { a = value; } //а тут мы меняем значение поля
            }

            public int Re_Line_B
            {
                get { return b; }
                set { b = value; }
            
            }

            public string Cheak_kv
            {
                get //это тоже свойство, которая возращает текст.
                {
                    if (a == b)
                    {
                        return "Это квадрат";
                    }
                    else
                    {
                        return "Это не квадрат";
                    }
                }
            }

        }



        private void button1_Click(object sender, EventArgs e) // Эта функция реагирует на нажатие кнопки.
        {
            listView1.Items.Clear(); // это мы чистим белое окошко от текста
            int a = Convert.ToInt32(textBox1.Text); //это создаём переменную а, которая принимем текст,
            //который мы вводим в тексбокс, но он текст и через конвер.ТоИнт32 мы переводим его в текст
            int b = Convert.ToInt32(textBox2.Text);//и тут также
            Rectangle A = new Rectangle(a,b); //создаём объект класса Рестангле и вызываем его конструктор
            //Параметры конструктора принимают значение а и б , которые мы создали выше

            listView1.Items.Add("P =" + A.perimetr()); // Добавляем на белое окошко результат метода нашего класса.
            listView1.Items.Add("S="+ A.s_funn());//и тут также
            label3.Text = A.Cheak_kv; //А тут просто вызывааем свойство и заносим его в текст лейбол.

            //Не забудь перед отправкой отчёта удалить все коментарии
        }
    }
}
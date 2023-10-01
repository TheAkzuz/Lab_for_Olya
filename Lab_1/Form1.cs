namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Rectangle //������ �����
        {
            private int a; // ��� ��������� ����, � ���� ������ �������� ��� ������
            private int b;

            public Rectangle(int a, int b) //��� �����������, �� ���� ��� �������, ������� ����� ��������� 
                //���-�� ��� �������� �������
            {
                
                this.a = a; //����� ���������� ����������� ��������� � ������� �����, ������� ����� this 
                //��� �������� ��������� ����� �����
                this.b = b;
            }

            public int perimetr() // ��� �������(�����), ������� ���������� ��������.
            {
                int P = this.a *2 + this.b *2;
                return P;
            }

            public int s_funn()
            {
                return this.a * this.b;
            }

            //��� ��������, ������� ��������� �������� � ���������� ������ ��� ������
            public int Re_Line_A
            {

                get { return a; }//��� �� �������� �������� ����
                set { a = value; } //� ��� �� ������ �������� ����
            }

            public int Re_Line_B
            {
                get { return b; }
                set { b = value; }
            
            }

            public string Cheak_kv
            {
                get //��� ���� ��������, ������� ��������� �����.
                {
                    if (a == b)
                    {
                        return "��� �������";
                    }
                    else
                    {
                        return "��� �� �������";
                    }
                }
            }

        }



        private void button1_Click(object sender, EventArgs e) // ��� ������� ��������� �� ������� ������.
        {
            listView1.Items.Clear(); // ��� �� ������ ����� ������ �� ������
            int a = Convert.ToInt32(textBox1.Text); //��� ������ ���������� �, ������� �������� �����,
            //������� �� ������ � ��������, �� �� ����� � ����� ������.�����32 �� ��������� ��� � �����
            int b = Convert.ToInt32(textBox2.Text);//� ��� �����
            Rectangle A = new Rectangle(a,b); //������ ������ ������ ��������� � �������� ��� �����������
            //��������� ������������ ��������� �������� � � � , ������� �� ������� ����

            listView1.Items.Add("P =" + A.perimetr()); // ��������� �� ����� ������ ��������� ������ ������ ������.
            listView1.Items.Add("S="+ A.s_funn());//� ��� �����
            label3.Text = A.Cheak_kv; //� ��� ������ ��������� �������� � ������� ��� � ����� ������.

            //�� ������ ����� ��������� ������ ������� ��� ����������
        }
    }
}
namespace FormsDZ_1
{//������� 1
//������������ ���������, ������� ��������� ������������ ������������ ����� ������ �� ��������� ��������.���������� ������� �� ���� ���� � ������� ���� � ���� ������.������������ �����
//������� ������� ������ ���� ��� ������. ���� ������ �����������
//����������. � ���� ������ ������������ �������� �����, � �������
//����� ���� ����� � ������ ����� ������, �������� �*.doc�. ��������� ����� ������������ � ������.
    public partial class Form1 : Form
    {
        Form2 form2 = null;
        public Form1()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            btnClose.Click += BtnClose_Click;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Show();
        }

    }
}